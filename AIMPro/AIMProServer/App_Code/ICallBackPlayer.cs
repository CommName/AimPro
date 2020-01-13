using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

[ServiceContract]
public interface ICallBackPlayer
{
    [OperationContract]
    void PlayersInTheRoom(List<string> players);

    [OperationContract]
    void updateTargets(List<Target> targets);

    [OperationContract]
    void GameStarted();

    [OperationContract]
    void GameStops();

    [OperationContract]
    void GameStats();

    [OperationContract]
    //Everytime it hits it sends how mutch points player has earned
    void EarnedPoints(int points); 

}