using System;
using System.Collections.Generic;
using System.Linq;
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

    public bool JoinRoom(int Roomid, object subscriber)
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

    public void CreateRoom(RoomProperties settings, object subscirber)
    {
        RoomFactory fact = new RoomFactory();
        this.Rooms.Add(fact.CreateRoom());
    }

    public void WatchRoom(int Roomid , object subscriber)
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

    public List<RoomProperties> getRooms()
    {
        List<RoomProperties> rooms = new List<RoomProperties>();

        foreach(Room r in this.Rooms)
        {
            if (!r.RoomPropertes.Hidden)
            {
                rooms.Add(r.RoomPropertes);
            }
        }

        return rooms;
    }
}