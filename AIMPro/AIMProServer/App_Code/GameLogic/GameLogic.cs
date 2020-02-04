using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for GameLogic
/// </summary>
public abstract class GameLogic
{
    public Timer timer;

    public Room room { get; set; }
    public Dictionary<string, Shooter> players { get; set; }
    public List<Target> targets { get; set; }
    public TargetTypes TargetTypesAllowed { get; set; }

    public TargetFactory targetFactory { get; set; }

    public Subscriber publisher { get; set; }

    public abstract void start();

    public abstract int getEarnedElo(string username);

    public abstract void submitHit(string username, int x, int y);


    protected void gameEnds(object sender, ElapsedEventArgs e)
    {
        timer.Stop();
        publisher.NotifyGameStoped();
        saveResults();
        this.room.FinishGame();
    }


    public void saveResults()
    {
        lock (players) {
            Matches newMatch = new Matches();
            newMatch.TypeOfMatch = (int)this.room.RoomPropertes.GameMode;
            newMatch.GameSeed = this.room.RoomPropertes.seed;
            newMatch.TargetsUsed = (int)this.room.RoomPropertes.TargetTypesAllowed;
            newMatch.CursorUsed = (int)this.room.RoomPropertes.CursorType;
            List<Tuple<User, UserMatch>> usersAndReuslts = new List<Tuple<User, UserMatch>>();

            DataBaseAPI db = new DataBaseAPI();
            foreach (var player in players)
            {
                User user = db.getUser(player.Value.username);
                user.Elo += getEarnedElo(user.Username);
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
        timer = new Timer(1000 * 60 * 1);
        timer.Elapsed += gameEnds;
    }
}