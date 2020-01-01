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
    string username = "";


    public ICallBackPlayer getCallBack()
    {
        return OperationContext.Current.GetCallbackChannel<ICallBackPlayer>();
    }
    public void createRoom(RoomProperties settings)
    {
        if (username == "")
        {
            throw new FaultException<Exception>(new Exception("You need to login first!"));
        }
        RoomDispatcher.Instance.CreateRoom(settings,username,getCallBack());
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
        if (username == "")
        {
            throw new FaultException<Exception>(new Exception("You need to login first!"));
        }
        RoomDispatcher.Instance.JoinRoom(id,username,getCallBack());
    }

    public void submitHit(int x, int y)
    {
        if (username == "")
        {
            throw new FaultException<Exception>(new Exception("You need to login first!"));
        }
        RoomDispatcher.Instance.SubmitHit(username,x,y);
    }


    public void leaveRoom()
    {
        if (username == "")
        {
            throw new FaultException<Exception>(new Exception("You need to login first!"));
        }
        RoomDispatcher.Instance.LeaveRoom(username);
    }

    public bool login(string username, byte[] pass)
    {
        Querry querry = new Querry();
        if(querry.login(username, pass))
        {
            this.username = username;
            return true;
        }
        return false;
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



    public Profile getProfileStatistics(string username)
    {
       
        Querry querry = new Querry();
        return querry.getProfile(username);
    }

    public List<MatchStatistics> getProfileMatchHistory(string  username)
    {
        Querry querry = new Querry();
        return querry.getProfileHistory(username);
    }

    public void logout()
    {
        if (this.username != "")
        {
            leaveRoom();
            this.username = "";
        }
    }

    public void startGame()
    {
        throw new NotImplementedException();
    }
}
