using AIMProLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Room
/// </summary>
public class Room
{

    protected static int lastId = 0; //TODO change id to string 
    protected int id;
    protected byte[] password;
    protected RoomProperties roomProperties;
    protected List<string> players;
    protected List<string> observers;
    protected bool gameStarted;
    protected JoinFunction join;

    protected Hashtable playersDone;

    //GETERS
    public int ID { get { return id; } }
    public RoomProperties RoomPropertes { get { return roomProperties; } }


    void startGame()
    {
        if (gameStarted)
            return;
        gameStarted = true;
        playersDone = new Hashtable();
        foreach(string username in players)
        {
            //hash table
        }

    }

    public void submitNumberOfHits(string username, int numbOfHits)
    {
        Matches match = new Matches();
        match.NumberOfHits = numbOfHits;
        match.TotalNumberOfTargets = this.roomProperties.numberOfTargets;
        DataBaseAPI database = new DataBaseAPI();
        database.AddUserMatch(username, match);
    }

    //Construcots
    public Room()
    {
        this.id = lastId++;
        password = null;
        players = new List<string>();
        observers = new List<string>();
        gameStarted = false;
        this.join = null;

    }

    public Room(RoomProperties properties) : this()
    {
        this.roomProperties = properties;
        if((this.roomProperties.Settings & RoomSettings.PasswordProtected) != 0)
        {
            //Set password
        }
        SetJoinFunction();

    }

    public RoomState RoomState
    {
        get
        {
            RoomState roomstate = new RoomState();
            roomstate.ID = this.id;
            roomstate.gameModes = this.RoomPropertes.GameMode;
            roomstate.RoomSettings = this.RoomPropertes.Settings;
            roomstate.Name = this.roomProperties.Name;
            roomstate.maxNumberOfPlayers = this.RoomPropertes.maxPlayers;
            roomstate.currentNumberOfPlayers = this.players.Count;
            return roomstate;
        }
    }

    public void SetJoinFunction()
    {
        this.join = new PublicJoin(this);

        if((this.RoomPropertes.Settings & RoomSettings.PasswordProtected)!=0)
        {
            this.join = new PublicJoin(this.join);
        }

        if ((this.RoomPropertes.Settings & RoomSettings.EloRestricted) != 0)
        {
            this.join = new PublicJoin(this.join);
        }

    }

    public bool JoinRoom(string player)
    {
        return this.join.joinRoom(player);
    }

    public bool SpectateRoom(string spec)
    {
        return this.join.joinObservers(spec);
    }

    public void LeaveRoom(string player)
    {
        this.players.Remove(player);
        this.observers.Remove(player);
    }

    public abstract class JoinFunction
    {
        public Room room = null;
        public JoinFunction parent = null;

        public JoinFunction()
        {
            room = null;
            parent = null;
        }
        public JoinFunction(Room room)
        {
            this.room = room;
        }

        public JoinFunction(JoinFunction parent)
        {
            this.parent = parent;
        }


        public virtual bool joinRoom(string player)
        {
            if(room.players.Count >= this.room.roomProperties.maxPlayers)
            {
                return false;
            }
            this.room.players.Add(player);
            joinObservers(player);
            if(room.players.Count >= this.room.roomProperties.maxPlayers)
            {
                room.startGame();
            }
            return true;
        }

        public virtual bool joinObservers(string player)
        {
            this.room.observers.Add(player);
            return true;
        }
    }

}