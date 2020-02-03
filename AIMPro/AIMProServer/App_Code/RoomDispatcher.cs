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

    protected Dictionary<int ,Room> Rooms;
    protected Dictionary<string, Room> PlayersRoom;


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
        Rooms = new Dictionary<int, Room>();
        PlayersRoom = new Dictionary<string, Room>();
    }

    public void DeleteEmptyRoom(int roomId)
    {
        Rooms.Remove(roomId);
    }

    public void startGame(string username)
    {
        Room room;

        if (PlayersRoom.TryGetValue(username, out room))
        {
            if (room != null)
            {
                room.startGame(username);
            }
        }
    }

    public void SubmitHit(string username, int x, int y)
    {
        Room room;
        if(PlayersRoom.TryGetValue(username,out room))
        {
            if(room!=null)
                room.submitHit(username, x, y);
        }
        else
        {
            throw new FaultException<Exception>(new Exception("Room could not be found!"));
        }
    }



    public bool JoinRoom(int Roomid, string username, ICallBackPlayer callback)
    {

        LeaveRoom(username);
        Room room;
        if (Rooms.TryGetValue(Roomid, out room))
        {

            if(room.JoinRoom(username, callback))
            {
                PlayersRoom[username] = room;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            throw new FaultException<Exception>(new Exception("Room could not be found!"));
        }
    }

    public void CreateRoom(RoomProperties settings, string username, ICallBackPlayer callback)
    {
        Room newroom = new Room(settings);
        this.Rooms.Add(newroom.ID , newroom);
        this.JoinRoom(newroom.ID, username, callback);
    }

    public void LeaveRoom(string username)
    {
        Room room;

        if (PlayersRoom.TryGetValue(username, out room))
        {
            if (room!=null)
            {
                room.LeaveRoom(username);
                PlayersRoom[username] = null;
            }
        }
    }
        //TODO THROW EXCEPTION ROOM NOT FOUND

    public List<RoomState> getRooms()
    {
        List<RoomState> rooms = new List<RoomState>();
        foreach(Room r in this.Rooms.Values)
        {
            if ((r.RoomPropertes.Settings & RoomSettings.Hidden) == 0 && !r.GameStarted)
            {
                rooms.Add(r.RoomState);
            }
        }
        return rooms;
    }
}