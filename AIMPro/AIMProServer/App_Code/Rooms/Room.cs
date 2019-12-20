using AIMProLibrary;
using System;
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
    protected List<Object> players;
    protected List<Object> observers;
    protected bool gameStarted;
    protected JoinFunction join;

    //GETERS
    public int ID { get { return id; } }
    public RoomProperties RoomPropertes { get { return roomProperties; } }



    //Construcots
    public Room()
    {
        this.id = lastId++;
        password = null;
        players = new List<object>();
        observers = new List<object>();
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
            roomstate.Name = "";
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

    public bool JoinRoom(Object player)
    {
        return this.join.joinRoom(player);
    }

    public bool SpectateRoom(Object spec)
    {
        return this.join.joinObservers(spec);
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


        public virtual bool joinRoom(Object player)
        {
            if(room.players.Count >= this.room.roomProperties.maxPlayers)
            {
                return false;
            }
            this.room.players.Add(player);
            if(room.players.Count >= this.room.roomProperties.maxPlayers)
            {
                room.gameStarted = true;
                //TODO notify everyone gmae has started
            }
            return true;
        }

        public virtual bool joinObservers(Object player)
        {
            this.room.observers.Add(player);
            return true;
        }
    }


    public class Observer
    {

    }

}