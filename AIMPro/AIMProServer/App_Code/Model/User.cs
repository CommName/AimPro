using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
/// 
[DataContract]
public class User
{
    
    public int ID { get; set; }
    [DataMember]
    public string Username { get; set; }

    public byte[] Password { get; set; }

   [DataMember]
    public int Elo { get; set; }

    
    public ICollection<UserMatch> MatchHistory { get; set; }

 
}