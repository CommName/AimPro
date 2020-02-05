using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for Subscriber
/// </summary>
public class Publisher
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
            Thread gameStarter = new Thread(() =>
            {
                try
                {
                    shooter.callback.GameStarted();
                }
                catch (Exception e)
                {

                }
            });
            gameStarter.Start();
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
            Thread gamestppoer = new Thread(() =>
            {
                try
                {
                    shoter.callback.GameStops();
                }
                catch (Exception e)
                {

                }
            });
            gamestppoer.Start();

        }
    }

    public void UpdateTargets(List<Target> targets)
    {
        this.UpdateTargets(targets, subscribers);
    }

    public void UpdateTargets(List<Target> targets, List<Shooter> players)
    {
        lock (locker)
        {
            foreach (Shooter shooter in players)
            {
                Thread targetsender = new Thread(() =>
                {
                    try
                    {
                        shooter.callback.updateTargets(targets);
                    }
                    catch(Exception e)
                    {

                    }
                });
                targetsender.Start();
            }
        }

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
                    try
                    {
                        player.Value.callback.PlayersInTheRoom(playersInTheRoom);
                    }
                    catch (Exception e)
                    {
                        //Remove him from the room
                        RoomDispatcher.Instance.LeaveRoom(player.Key);
                    }
                }
            }
        });

        send.Start();

    }

    public void GameProfileChange()
    {

    }

}