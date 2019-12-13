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

    public void RemoveUser(User user)
    {

    }

    public User getUser(string username)
    {
        using (var db = new UserContext())
        {
            return db.Users.Where(b => b.Username == username).Include(b => b.MatchHistory).FirstOrDefault();
            
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