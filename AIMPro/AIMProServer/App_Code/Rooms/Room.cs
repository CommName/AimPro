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
    //Atributes
    protected static int lastId = 0; //TODO change id to string 
    protected int id;
    protected byte[] password;
    protected bool gameStarted;
    protected RoomProperties roomProperties;
    protected Dictionary<string, Shooter> players;
    protected Subscriber subscriber;

    //Strategy
    protected JoinFunction join;
    protected GameLogic gamelogic;

    //GETERS
    public int ID{ get { return id; } }
    public RoomProperties RoomPropertes { get { return roomProperties; } }
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
    public bool GameStarted { get { return gameStarted; } }

    public void startGame(string username)
    {
        if (gameStarted)
            return;
        if (username != this.players.First().Key)
            return;
        gameStarted = true;

        this.gamelogic.room = this;
        this.gamelogic.players = this.players;
    }

    public void FinishGame()
    {
        Dictionary<string, Shooter> copy = new Dictionary<string, Shooter>(players);
        foreach(var player in copy)
        {
            RoomDispatcher.Instance.LeaveRoom(player.Value.username);
        }
        RoomDispatcher.Instance.DeleteEmptyRoom(this.id);
    }

    public void submitHit(string username, int x, int y)
    {
        if (!gameStarted)
            return;
        this.gamelogic.submitHit(username, x, y);
    }

    //Construcots
    public Room()
    {
        this.id = lastId++;
        this.players = new Dictionary<string, Shooter>();
        password = null;
        gameStarted = false;
        this.join = null;
        this.subscriber = new Subscriber();

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

    public bool JoinRoom(string player, ICallBackPlayer callback)
    {
        return this.join.joinRoom(player, callback);
    }

    public void LeaveRoom(string player)
    {
        this.players.Remove(player);
        if (this.players.Count == 0)
        {
            FinishGame();
        }
        else
        {
            this.subscriber.PlayersInTheRoom(players);
        }
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


        public virtual bool joinRoom(string player, ICallBackPlayer callback)
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

                return true;
                room.subscriber.PlayersInTheRoom(room.players);
            }
        }

    }

}