using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AIMProServerService" in code, svc and config file together.
public class AIMProServerService : IAIMProServerService
{
    public bool login(string username, byte[] pass)
    {
        DataBaseAPI api = new DataBaseAPI();
        User user = api.getUser(username);
        return user.Username == username;
        //return true;
    }

    public bool signUp(string username, byte[] pass)
    {
        Querry querry = new Querry();
        querry.registry(username, pass);
        return true;
    }
}
