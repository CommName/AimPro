using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Querry
/// </summary>
public class Querry
{
    DataBaseAPI api = new DataBaseAPI();
    public bool registry(string username, byte[] password)
    {
        User newUser = api.getUserWithoutHistory(username);
        if (newUser != null)
        {
            return false;
        }
        newUser = new User();
        newUser.Username = username;
        newUser.Password = password;
        newUser.Elo = 1200;
        api.AddUser(newUser);
        return true;
    }

    public bool login(string username, byte[] password)
    {
        User user = api.getUserWithoutHistory(username);
        if(user == null)
        {
            return false;
        }
        if(user.Username == username && user.Password.SequenceEqual(password)){
            return true;
        }
        return false;
    }

    public User getUser(string username)
    {
        return api.getUser(username);
    }

    public List<Profile> getUsers()
    {
        return api.getUsers();
    }

    internal Profile getProfile(string  username)
    {
        return api.getProfileStatistics(username);
    }

    internal List<MatchStatistics> getProfileHistory(string username) {
        return api.GetMatchHistory(username);
    }

}