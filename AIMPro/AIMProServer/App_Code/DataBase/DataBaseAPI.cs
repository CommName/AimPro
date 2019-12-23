using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataBaseAPI
/// </summary>
using System.Data.Entity;
public class DataBaseAPI
{
    public DataBaseAPI()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void AddUser(User newUser)
    {
        using (var db = new UserContext())
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }
    }

    public void UpdateUsers(List<User> users, Matches match)
    {
        
        using(var db = new UserContext())
        {
            db.Matches.Add(match);
            foreach (User user in users) {

                User oldUser = db.Users.Where(b => b.Username == user.Username).Include(b => b.MatchHistory).FirstOrDefault();
                if (oldUser == null)
                {
                    throw new Exception("User not found");
                }
                oldUser.Username = user.Username;
                oldUser.Password = user.Password;
                oldUser.Elo = user.Elo;

                foreach (UserMatch match1 in user.MatchHistory)
                {
                    oldUser.MatchHistory.Add(match1);
                }
            }

            db.SaveChanges();
        }
        
    }


    internal Profile getProfileStatistics(string username)
    {
       // throw new NotImplementedException();
        
        Profile profile = new Profile();
        User user = new User();
        using (var db = new UserContext())
        {
            user = db.Users.Where(b => b.Username == username).FirstOrDefault();
            profile.Username = user.Username;
            profile.Elo = user.Elo;
            profile.MatchCount = db.UserMatch.Count(b => b.UserId == user.ID);
            profile.TotalHits = db.UserMatch.Where(b => b.UserId == user.ID).Sum(i => i.NumHits);
            profile.TotalMiss = db.UserMatch.Where(b => b.UserId == user.ID).Sum(i => i.NumMiss);
            profile.HitRatio = profile.TotalHits / (profile.TotalHits + profile.TotalMiss);
            //  profile.NumberDuel = db.UserMatch.Count(b => b.UserId == user.ID && b.MatchId == db.Matches.Where(u => u.TypeOfMatch == 1).Select(k => k.ID));

            profile.NumberDuel = 0;
            profile.NumberEndless = 0;
            profile.NumberFast = 0;
            profile.NumberFFA = 0;
            profile.NumberPrecise = 0;


            //profile.MatchCount = db.Matches.Count(b => b.UserId == userPom.ID);
            //user.TotalHits=db.Matches.Where(b=>b.UserId==userPom.ID).Sum(i=>i.t)


        }
        return profile;
    }

    internal List<MatchStatistics> GetMatchHistory(string username) {

        List<MatchStatistics> matchStatistics = new List<MatchStatistics>();

        using (var db = new UserContext())
        {
            int userId = db.Users.Where(k => k.Username == username).Select(i => i.ID).FirstOrDefault();

          List <UserMatch> listUserHistory = db.UserMatch.Where(k => k.UserId == userId).ToList();
            foreach(UserMatch m in listUserHistory)
            {
                MatchStatistics match = new MatchStatistics();
                match.MatchRank = m.Rank;
                match.NumberOfHits = m.NumHits;
                match.NumberOfMiss = m.NumMiss;
                match.NumberOfPoints = m.Points;
                match.TypeOfGame = db.Matches.Where(n => n.ID == m.MatchId).Select(i => i.TypeOfMatch).FirstOrDefault();
                matchStatistics.Add(match);

            }

        }
        return matchStatistics;

    }


    public void RemoveUser(User user)
    {
        using(var db = new UserContext())
        {
            User deletedUser = db.Users.Where(b => b.Username == user.Username).FirstOrDefault();
            if (deletedUser == null)
            {
                throw new Exception("No user found");
            }
            db.Users.Remove(deletedUser);
        }
    }

    public User getUser(string username)
    {
        using (var db = new UserContext())
        {
            return db.Users.Where(b => b.Username == username).Include(b => b.MatchHistory).FirstOrDefault();
            
        }
    }

    public List<User> getUsers()
    {
        using (var db = new UserContext())
        {
            return db.Users.Select(x=>x).OrderByDescending(x=>x.Elo).Take(100).ToList();

        }
    }


    public User getUserWithoutHistory(string username)
    {
        using (var db = new UserContext())
        {
            return db.Users.Where(b => b.Username == username).FirstOrDefault();
        }
    }
}