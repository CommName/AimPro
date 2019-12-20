using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JoinFactory
/// </summary>
public class JoinFactory
{
    public JoinFactory()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public Room.JoinFunction GetJoinFunction()
    {
        return new PublicJoin();
    }

}