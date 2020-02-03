using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for Subscriber
/// </summary>
public class Subscriber
{
    private object locker = false;
    public List<Shooter> subscribers { get; set; }

    
    public void NotifyGameStart()
    {
        this.NotifyGameStart(subscribers);
    }
    public void NotifyGameStart(List<Shooter> players)
    {
        foreach (Shooter shooter in players)
        {
            shooter.callback.GameStarted();
        }
    }

    public void NotifyGameStoped()
    {
        NotifyGameStoped(subscribers);
    }

    public void NotifyGameStoped(List<Shooter> shoters)
    {
        foreach(Shooter shoter in shoters)
        {
            shoter.callback.GameStops();
        }
    }

    public void UpdateTargets(List<Target> targets)
    {
        this.UpdateTargets(targets, subscribers);
    }

    public void UpdateTargets(List<Target> targets, List<Shooter> players)
    {
        Thread targetsender = new Thread(() =>
        {
            lock (locker)
            {
                foreach (Shooter shooter in players)
                {
                    shooter.callback.updateTargets(targets);
                }
            }
        });

        targetsender.Start();
    }

    public void PlayersInTheRoom(Dictionary<string, Shooter> players)
    {
        Thread send = new Thread(() =>
        {
            lock (locker)
            {
                List<Shooter> playersInTheRoom = new List<Shooter>();
                foreach (var player in players)
                {
                    playersInTheRoom.Add(player.Value);
                }
                foreach (var player in players)
                {
                    player.Value.callback.PlayersInTheRoom(playersInTheRoom);
                }
            }
        });

        send.Start();

    }

    public void GameProfileChange()
    {

    }

}