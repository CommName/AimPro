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

    public void UpdateUser(User user)
    {
        using(var db = new UserContext())
        {
            User oldUser = db.Users.Where(b => b.Username == user.Username).Include( b => b.MatchHistory).FirstOrDefault();
            if(oldUser == null)
            {
                throw new Exception("User not found");
            }
            oldUser.Username = user.Username;
            oldUser.Password = user.Password;
            oldUser.Elo = user.Elo;
            foreach (Matches match in user.MatchHistory)
            {
                oldUser.MatchHistory.Add(match);
            }
            db.SaveChanges();
        }
    }

    internal Profile getProfileStatistics(string username)
    {
        throw new NotImplementedException();
        /*
        Profile user = new Profile();
        user.Username = username;
        User userPom = new User();
        using (var db = new UserContext())
        {
            userPom = db.Users.Where(b => b.Username == user.Username).FirstOrDefault();
            user.Elo = userPom.Elo;
            user.MatchCount = db.Matches.Count(b => b.UserId == userPom.ID);
            user.TotalHits=db.Matches.Where(b=>b.UserId==userPom.ID).Sum(i=>i.t)

            
        }*/

    }

    internal List<MatchStatistics> GetMatchHistory(string username) {
        throw new NotImplementedException();
        
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