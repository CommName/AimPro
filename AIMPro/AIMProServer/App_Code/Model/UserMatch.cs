using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for UserMatch
/// </summary>
/// 
[DataContract]
public class UserMatch
{
    public UserMatch()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public int ID { get; set; }
    public int MatchId { get; set; }
    public int UserId { get; set; }

    public  User User { get; set; }

    public Matches Match { get; set; }
    public int Points { get; set; }
    public int NumHits { get; set; }
    public int NumMiss { get; set; }
    public int Rank { get; set; }






}