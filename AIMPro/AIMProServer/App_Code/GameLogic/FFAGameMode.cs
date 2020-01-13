using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for FFAGameMode
/// </summary>
public class FFAGameMode : GameLogic
{
    Timer timer;

    const int maxNumberOfTargetsAtTheSameTime = 10;
    public FFAGameMode()
    {
        targetFactory = new TargetFactory();
        targetFactory.random = new Random(room.RoomPropertes.seed);
        targets = new List<Target>();
        publisher = new Subscriber();

    }

    public override int getEarnedElo(string username)
    {
        //FIDE ratings system applied just insted of 4 matches it's applaid for 4 players
        int earnedElo = 0;
        int numberOfPlayers = 0;
        Shooter shooter = players[username];
        DataBaseAPI api = new DataBaseAPI();
        foreach(var player in players)
        {
            if(player.Key != username)
            {
                User user = api.getUserWithoutHistory(player.Key);
                int delta = 400 + user.Elo;
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
        Subscriber subscriber = new Subscriber();
        List<Shooter> shooter = new List<Shooter>();
        foreach(var player in players)
        {
            shooter.Add(player.Value);
        }
        subscriber.subscribers = shooter;
        subscriber.UpdateTargets(targets);
        subscriber.NotifyGameStart();

        timer = new Timer(1000 * 60 * 10);
        timer.Elapsed += gameEnds;
        timer.Start();

    }


    void gameEnds(object sender, ElapsedEventArgs e)
    {
        timer.Stop();
        publisher.NotifyGameStoped();
        saveResults();
        this.room.FinishGame();
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