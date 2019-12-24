using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    public Matches Match { get; set; }
    public User User { get; set; }

    [Key, Column(Order = 1)]
    public int MatchId { get; set; }
    [Key, Column(Order = 2)]
    public int UserId { get; set; }

 

 
    public int? Points { get; set; }
    public int? NumHits { get; set; }
    public int? NumMiss { get; set; }
    public int Rank { get; set; }










}