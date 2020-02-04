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

        players[username].ready = true;
        subscriber.PlayersInTheRoom(players);

        
        foreach(var player in players)
        {
            if (!player.Value.ready)
                return;
        }

        gameStarted = true;

        if (roomProperties.seed==0)
        {
            roomProperties.seed = Environment.TickCount;
        }
        

        switch (this.RoomPropertes.GameMode)
        {
            case GameMode.EndlessCampaign: { this.gamelogic = new EndlessCamp(roomProperties.seed); break; }
            case GameMode.FastShooting: { this.gamelogic = new FastShooting(roomProperties.seed); break; }
            case GameMode.Duel: 
            case GameMode.MultyPlayerShootOut: 
                { this.gamelogic = new MultyPlayerShootOut();  break; }
        }

        this.gamelogic.room = this;
        this.gamelogic.players = this.players;
        this.gamelogic.start();
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
        this.subscriber = new Subscriber();

    }

   

    public Room(RoomProperties properties) : this()
    {
        this.roomProperties = properties;
        if((this.roomProperties.Settings & RoomSettings.PasswordProtected) != 0)
        {
            //Set password
        }

    }

    public bool JoinRoom(string player, ICallBackPlayer callback)
    {

        
        lock (players)
        {
            if ((this.RoomPropertes.Settings & RoomSettings.PasswordProtected) != 0)
            {
                //Password check
            }

            if ((this.RoomPropertes.Settings & RoomSettings.EloRestricted) != 0)
            {
                //Elo check
            }
            if (players.Count >= this.roomProperties.maxPlayers)
            {
                return false;
            }

            DataBaseAPI db = new DataBaseAPI();
            User user = db.getUser(player);

            Shooter newshoter = new Shooter();
            newshoter.username = player;
            newshoter.callback = callback;
            newshoter.elo = user.Elo;

            players.Add(player, newshoter);

            subscriber.PlayersInTheRoom(players);
            return true;

        }
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


}