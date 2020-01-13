using System;
using System.Collections.Generic;
using System.Linq;
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
        foreach(Shooter shooter in players)
        {
            shooter.callback.updateTargets(targets);
        }
    }

    public void PlayersInTheRoom(Dictionary<string, Shooter> players)
    {
        lock (locker)
        {
            List<string> playersInTheRoom = new List<string>();
            foreach(var player in players)
            {
                playersInTheRoom.Add(player.Value.username);
            }
            foreach(var player in players)
            {
                player.Value.callback.PlayersInTheRoom(playersInTheRoom);
            }
        }

    }

    public void GameProfileChange()
    {

    }

}