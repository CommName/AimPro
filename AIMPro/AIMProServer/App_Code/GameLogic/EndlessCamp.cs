using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EndlessCamp
/// </summary>
public class EndlessCamp  : MultyPlayerShootOut
{
    public EndlessCamp() : base()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public EndlessCamp(EndlessCamp copy) : base(copy)
    {

    }

    public EndlessCamp(int seed = 0) : base(seed)
    {

    }


    public override void start()
    {
        initPublisher();
        fillTagets();
        publisher.NotifyGameStart();

    }

    public override void submitHit(string username, int x, int y)
    {
        base.submitHit(username, x, y);
        if (players[username].points > 100)
        {
            FinishGame();
        }
    }

}