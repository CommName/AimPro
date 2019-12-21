using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AIMProLibrary;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AIMProServerService" in code, svc and config file together.
[ServiceBehavior(InstanceContextMode =InstanceContextMode.PerSession)]
public class AIMProServerService : IAIMProServerService
{
    public void createRoom(RoomProperties settings)
    {
        RoomDispatcher.Instance.CreateRoom(settings,null);
    }

    public User getProfile(string username)
    {
        Querry querry = new Querry();
        return querry.getUser(username);
    }

    public List<RoomState> GetRooms()
    {
        return RoomDispatcher.Instance.getRooms();
    }

    public void joinRoom(int id)
    {
        RoomDispatcher.Instance.JoinRoom(id,null);
    }

    public bool login(string username, byte[] pass)
    {
        Querry querry = new Querry();
        return querry.login(username, pass);
    }

    public bool signUp(string username, byte[] pass)
    {
        Querry querry = new Querry();
        querry.registry(username, pass);
        return true;
    }

    public List<User> getProfiles()
    {
        Querry querry = new Querry();
        return querry.getUsers();
    }
    int i = 0;
    public int debug()
    {
        return i++;
    }
}
