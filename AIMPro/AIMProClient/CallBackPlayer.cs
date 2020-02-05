using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIMProClient.AIMProService;
using System.ServiceModel;
using System.ServiceModel.Channels;
using  AIMProClient;
using System.Windows.Forms;

/// <summary>
/// Summary description for CallBackPlayer
/// </summary>
public class CallBackPlayer : IAIMProServerServiceCallback
{
    public void EarnedPoints(int points)
    {
        FormLayer.Instance.lobbyForm.gameController.updateScore(points);
    }

    public void GameStarted()
    {
        //Call game view
        FormLayer.Instance.lobbyForm.gameController.loadGameView();
        //MessageBox.Show("Pocetak igre");
    }

    public void GameStats()
    {

    }

    public void GameStops()
    {
        FormLayer.Instance.lobbyForm.gameController.krajIgre();
    }

    public void PlayersInTheRoom(List<Shooter> players)
    {
        FormLayer.Instance.lobbyForm.lobbyController.preuzmiLobbyUsere(players);
    }

    public void updateTargets(List<Target> targets)
    {
        FormLayer.Instance.lobbyForm.gameController.targets = targets;
        FormLayer.Instance.lobbyForm.gameController.targets.Reverse();
        FormLayer.Instance.lobbyForm.gameController.canvas.Invalidate();
    }
}

