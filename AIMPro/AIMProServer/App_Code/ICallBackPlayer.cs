using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

[ServiceContract]
public interface ICallBackPlayer
{
    [OperationContract(IsOneWay = true)]
    void PlayersInTheRoom(List<string> players);

    [OperationContract(IsOneWay = true)]
    void updateTargets(List<Target> targets);

    [OperationContract(IsOneWay = true)]
    void GameStarted();

    [OperationContract(IsOneWay = true)]
    void GameStops();

    [OperationContract(IsOneWay = true)]
    void GameStats();

    [OperationContract(IsOneWay = true)]
    //Everytime it hits it sends how mutch points player has earned
    void EarnedPoints(int points); 

}