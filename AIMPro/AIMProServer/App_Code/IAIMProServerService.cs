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

    [OperationContract]
    void logout();

    [OperationContract]
    void startGame();

    [OperationContract]
    bool signUp(string username, byte[] pass);

    [OperationContract]
    User getProfile(string username);

    [OperationContract]
    void createRoom(RoomProperties settings);

    [OperationContract]
    void joinRoom(int id);

    [OperationContract]
    List<RoomState> GetRooms();

    [OperationContract]
    List< User> getProfiles();

    [OperationContract]
    void leaveRoom();

    [OperationContract]
    Profile getProfileStatistics(string username);

    [OperationContract]
    List<MatchStatistics> getProfileMatchHistory(string username);

    [OperationContract]
    void submitHit(int x, int y);

}
