﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FastShooting
/// </summary>
public class FastShooting : GameLogic
{

    public Dictionary<string, MultyPlayerShootOut> playersGame;

    public FastShooting() : base()
    {

    }

    public FastShooting(int seed, TargetTypes allowed = TargetTypes.None) : base(seed, allowed) 
    {
       
    }


    public override void start()
    {
        playersGame = new Dictionary<string, MultyPlayerShootOut>();
        foreach(var shooter in players)
        {
            MultyPlayerShootOut game = new MultyPlayerShootOut(this.seed, TargetTypesAllowed);
            
            Dictionary<string, Shooter> localPlayers = new Dictionary<string, Shooter>();
            localPlayers.Add(shooter.Key, shooter.Value);
            game.players = localPlayers;

            game.initPublisher();
            game.fillTagets();

            playersGame.Add(shooter.Key, game);
        }
        initPublisher();
        publisher.NotifyGameStart();
        timer.Start();
    }

    public override void submitHit(string username, int x, int y)
    {
        playersGame[username].submitHit(username, x, y);
    }
}