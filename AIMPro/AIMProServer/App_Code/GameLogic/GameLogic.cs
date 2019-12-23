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


    public void saveResults()
    {
        lock (players) {
            Matches newMatch = new Matches();
            newMatch.TypeOfMatch = (int)this.room.RoomPropertes.GameMode;
            DataBaseAPI db = new DataBaseAPI();
            List<Tuple<User, UserMatch>> usersAndReuslts = new List<Tuple<User, UserMatch>>();
            foreach(var player in players)
            {
                User user = db.getUser(player.Value.username);
                UserMatch match = new UserMatch();
                match.Match = newMatch;
                match.NumHits = player.Value.numberOfHits;
                match.NumMiss = player.Value.numbeerOfMisses;
                match.Points = 100;
                match.Rank = 1;
                match.User = user;

                usersAndReuslts.Add(new Tuple<User, UserMatch>(user, match));

            }

            db.UpdateUsers(usersAndReuslts, newMatch);

        
        }
    }

    public GameLogic()
    {

    }
}