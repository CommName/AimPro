using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subscriber
/// </summary>
public class Subscriber
{
    private object locker = false;

    public void NotifyGameStart()
    {

    }

    public void AddTargets()
    {

    }

    public void RemoveTarget()
    {

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