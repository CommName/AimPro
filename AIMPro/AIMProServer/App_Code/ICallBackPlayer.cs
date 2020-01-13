using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public interface ICallBackPlayer
{
    void PlayersInTheRoom(List<string> players);

    void updateTargets(List<Target> targets);

    void GameStarted();

    void GameStops();

    void GameStats();

    //Everytime it hits it sends how mutch points player has earned
    void EarnedPoints(int points); 

}