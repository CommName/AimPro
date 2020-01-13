using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIMProClient.AIMProService;
using System.ServiceModel;
using System.ServiceModel.Channels;
using  AIMProClient;


/// <summary>
/// Summary description for CallBackPlayer
/// </summary>
public class CallBackPlayer : IAIMProServerServiceCallback
{
    public void EarnedPoints(int points)
    {
        throw new NotImplementedException();
    }

    public void GameStarted()
    {
        throw new NotImplementedException();
    }

    public void GameStats()
    {
        throw new NotImplementedException();
    }

    public void GameStops()
    {
        throw new NotImplementedException();
    }

    public void PlayersInTheRoom(List<string> players)
    {
        FormLayer.Instance.lobbyForm.lobbyController.preuzmiLobbyUsere(players);
    }

    public void updateTargets(List<Target> targets)
    {
        throw new NotImplementedException();
    }
}

