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
    protected Dictionary<string, Shooter> players;
    protected bool gameStarted;
    protected JoinFunction join;
   
    //GETERS
    public int ID { get { return id; } }
    public RoomProperties RoomPropertes { get { return roomProperties; } }

    void startGame()
    {
        if (gameStarted)
            return;
        gameStarted = true;
    }

    public void submitHit(string username, int x, int y)
    {
        //TODO Call game logic to check if it hitted or not
        saveResults(username);
    }

    //Construcots
    public Room()
    {
        this.id = lastId++;
        this.players = new Dictionary<string, Shooter>();
        password = null;
        gameStarted = false;
        this.join = null;

    }

    public void saveResults(string username)
    {
        Shooter results;
        if(this.players.TryGetValue(username,out results))
        {
            lock (results)
            {
                if (!results.done) // Can't write same 
                {
                    results.done = true;
                    Matches match = new Matches();
                    match.NumberOfHits = results.numberOfHits; 
                    match.TotalNumberOfTargets = results.numberOfHits+results.numbeerOfMisses;
                    DataBaseAPI database = new DataBaseAPI();
                    database.AddUserMatch(username, match);
                }
            }

        }
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

    public bool JoinRoom(string player, Object callback)
    {
        return this.join.joinRoom(player, callback);
    }


    public void LeaveRoom(string player)
    {
        this.players.Remove(player);
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


        public virtual bool joinRoom(string player, Object callback)
        {
            lock (this.room)
            {
                if (room.players.Count >= this.room.roomProperties.maxPlayers)
                {
                    return false;
                }

                Shooter newshoter = new Shooter();
                newshoter.username = player;
                newshoter.callback = callback; 
                this.room.players.Add(player,newshoter);
                if (room.players.Count >= this.room.roomProperties.maxPlayers)
                {
                    room.startGame();
                }
                return true;
            }
        }

    }

}