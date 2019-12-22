using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using AIMProLibrary;

/// <summary>
/// Summary description for RoomDispatcher
/// </summary>
public class RoomDispatcher
{

    protected List<Room> Rooms;

    protected static object locker = false;
    protected static RoomDispatcher instance = null;
    public static RoomDispatcher Instance
    {
        get
        {
            lock (locker)
            {
                if (instance == null)
                    instance = new RoomDispatcher();
            }
            return instance;
        }
    }
    public RoomDispatcher()
    {
        Rooms = new List<Room>();

    }

    public void SubmitResut(int Roomid, string username, int numberOfHits)
    {
        foreach (Room r in Rooms)
        {
            if (r.ID == Roomid)
            {
                r.submitNumberOfHits(username, numberOfHits);
                return;
            }
        }
        throw new FaultException<Exception>(new Exception("Room could not be found!"));
    }


    public bool JoinRoom(int Roomid, string subscriber)
    {
        foreach(Room r in Rooms)
        {
            if(r.ID == Roomid)
            {
                return r.JoinRoom(subscriber);
            }
        }
        return false;
    }

    public void CreateRoom(RoomProperties settings, string subscirber)
    {
        this.Rooms.Add(new Room(settings));
    }

    public void LeaveRoom(string player)
    {
        
    }

    public void WatchRoom(int Roomid , string subscriber)
    {
        foreach (Room r in Rooms)
        {
            if (r.ID == Roomid)
            {
                r.SpectateRoom(subscriber);
                return;
            }
        }
        //TODO THROW EXCEPTION ROOM NOT FOUND
    }

    public List<RoomState> getRooms()
    {
        List<RoomState> rooms = new List<RoomState>();

        foreach(Room r in this.Rooms)
        {
            if ((r.RoomPropertes.Settings & RoomSettings.Hidden) == 0)
            {
                rooms.Add(r.RoomState);
            }
        }

        return rooms;
    }
}