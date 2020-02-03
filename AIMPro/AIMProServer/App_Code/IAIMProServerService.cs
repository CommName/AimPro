using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AIMProLibrary;

namespace AIMProServer { }
[ServiceContract (CallbackContract = typeof (ICallBackPlayer))]

public interface IAIMProServerService
{
    [OperationContract]
    bool login(string username, byte[] pass);

    [OperationContract(IsOneWay = true)]
    void logout();

    [OperationContract(IsOneWay = true)]
    void startGame();

    [OperationContract]
    bool signUp(string username, byte[] pass);

    [OperationContract]
    User getProfile(string username);

    [OperationContract(IsOneWay = true)]
    void createRoom(RoomProperties settings);

    [OperationContract(IsOneWay = true)]
    void joinRoom(int id);

    [OperationContract]
    List<RoomState> GetRooms();

    [OperationContract]
    List< User> getProfiles();

    [OperationContract(IsOneWay = true)]
    void leaveRoom();

    [OperationContract]
    Profile getProfileStatistics(string username);

    [OperationContract]
    List<MatchStatistics> getProfileMatchHistory(string username);

    [OperationContract(IsOneWay = true)]
    void submitHit(int x, int y);

}
