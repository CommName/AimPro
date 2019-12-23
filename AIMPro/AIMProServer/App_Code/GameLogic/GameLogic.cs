using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameLogic
/// </summary>
public abstract class GameLogic
{

    public Dictionary<string, Shooter> players;
    public Object[] targets;
    public TargetTypes TargetTypesAllowed;

    public abstract void start();

    public abstract void pause();

    public abstract void submitHit(string username, int x, int y);


    public GameLogic()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}