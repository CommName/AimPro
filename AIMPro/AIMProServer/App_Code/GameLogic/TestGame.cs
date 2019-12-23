using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TestGame
/// </summary>
public class TestGame :GameLogic
{
    public TestGame()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public override void pause()
    {
        throw new NotImplementedException();
    }

    public override void start()
    {
        throw new NotImplementedException();
    }

    public override void submitHit(string username, int x, int y)
    {
        if (x == 0 && y == 0)
        {
            this.players[username].numberOfHits++;
        }
        else
        {
            this.players[username].numbeerOfMisses--;
        }
        room.FinishGame();
    }
}