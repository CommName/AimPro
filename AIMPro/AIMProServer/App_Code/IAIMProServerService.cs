using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AIMProLibrary;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAIMProServerService" in both code and config file together.
[ServiceContract]
public interface IAIMProServerService
{
    [OperationContract]
    bool login(string username, byte[] pass);

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
    Profile getProfileStatistics(string username);

    [OperationContract]
    List<MatchStatistics> getProfileMatchHistory(string username);

    [OperationContract]
    void submitHit(int x, int y);



}
