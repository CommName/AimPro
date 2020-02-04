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
    public int seed { get; set; }

    public Room room { get; set; }
    public Dictionary<string, Shooter> players { get; set; }
    public TargetTypes TargetTypesAllowed { get; set; }

    public Subscriber publisher { get; set; }

    public abstract void start();

    public int getEarnedElo(string username)
    {
        //FIDE ratings system applied just insted of 4 matches it's applaid for 4 players
        int earnedElo = 0;
        int numberOfPlayers = 0;
        Shooter shooter = players[username];
        foreach (var player in players)
        {
            if (player.Key != username)
            {
                int delta = 400 + player.Value.elo;
                if (shooter.points > player.Value.points)
                {
                    earnedElo += delta;
                }
                else
                {
                    earnedElo -= delta;
                }
            }
            numberOfPlayers++;
        }

        return earnedElo / numberOfPlayers;
    }

    public void initPublisher()
    {
        publisher = new Subscriber();
        List<Shooter> shooter = new List<Shooter>();
        foreach (var player in players)
        {
            shooter.Add(player.Value);
        }
        publisher.subscribers = shooter;
    }

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