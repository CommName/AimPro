using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameLogic
/// </summary>
public abstract class GameLogic
{

    public Room room { get; set; }
    public Dictionary<string, Shooter> players { get; set; }
    public Object[] targets { get; set; }
    public TargetTypes TargetTypesAllowed { get; set; }

    public abstract void start();

    public abstract void pause();

    public abstract void submitHit(string username, int x, int y);


    public void saveResults(string username)
    {
        Shooter results;
        if (this.players.TryGetValue(username, out results))
        {
            lock (results)
            {
                if (!results.done)
                {
                    //TODO add new atributes
                    results.done = true;
                    Matches match = new Matches();
                    match.NumberOfHits = results.numberOfHits;
                    match.TotalNumberOfTargets = results.numberOfHits + results.numbeerOfMisses;
                    DataBaseAPI database = new DataBaseAPI();
                    database.AddUserMatch(username, match);
                }
            }

        }
    }

    public GameLogic()
    {

    }
}