using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public byte[] Password { get; set; }

    public int Elo { get; set; }

    public ICollection<Matches> MatchHistory { get; set; }

 
}