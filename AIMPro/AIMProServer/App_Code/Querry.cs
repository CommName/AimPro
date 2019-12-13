using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Querry
/// </summary>
public class Querry
{
    public void registry(string username, byte[] password)
    {
        User newUser = new User();
        newUser.Username = username;
        newUser.Password = password;
        newUser.Elo = 1200;
        DataBaseAPI api = new DataBaseAPI();
        api.AddUser(newUser);

    }

    public void login(string username, byte[] password)
    {

    }

}