using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for FFAGameMode
/// </summary>
public class MultyPlayerShootOut : GameLogic
{
    
    const int maxNumberOfTargetsAtTheSameTime = 10;
    public MultyPlayerShootOut()
    {
        targets = new List<Target>();
        targetFactory = new TargetFactory();
        targetFactory.random = new Random(/*room.RoomPropertes.seed*/);
        targetFactory.actieTargets = this.targets;
        publisher = new Subscriber();

    }

    public override int getEarnedElo(string username)
    {
        //FIDE ratings system applied just insted of 4 matches it's applaid for 4 players
        int earnedElo = 0;
        int numberOfPlayers = 0;
        Shooter shooter = players[username];
        foreach(var player in players)
        {
            if(player.Key != username)
            {
                int delta = 400 + player.Value.elo;
                if (shooter.points > player.Value.points)
                {
                    earnedElo += delta;
                }
                else
                {
                    earnedElo -= delta;
                }
            }
            numberOfPlayers++;
        }

        return earnedElo/numberOfPlayers;
    }

    public override void start()
    {
        while(targets.Count < maxNumberOfTargetsAtTheSameTime)
        {
            targets.Add(this.targetFactory.getNextTarget());
        }
        publisher = new Subscriber();
        List<Shooter> shooter = new List<Shooter>();
        foreach(var player in players)
        {
            shooter.Add(player.Value);
        }
        publisher.subscribers = shooter;
        publisher.UpdateTargets(targets);
        publisher.NotifyGameStart();

        timer.Start();

    }


    public override void submitHit(string username, int x, int y)
    {
        Shooter player = players[username];
        lock (targets)
        {
            foreach (Target t in targets)
            {
                if (t.TryToHit(player, x, y))
                {
                    while (targets.Count < maxNumberOfTargetsAtTheSameTime)
                    {
                        targets.Add(targetFactory.getNextTarget());
                    }
                    publisher.UpdateTargets(targets);
                    return;
                }

            }
            player.numbeerOfMisses++;
        }
    }
}