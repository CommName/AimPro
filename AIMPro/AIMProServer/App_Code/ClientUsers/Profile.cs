using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


/// <summary>
/// Summary description for Profile
/// </summary>
[DataContract]
public class Profile
{

    [DataMember]
    public string Username { get; set; }

    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public int Elo { get; set; }

    [DataMember]
    public double HitRatio { get; set; }

    [DataMember]
    public int MatchCount { get; set; }

    [DataMember]
    public int TotalHits { get; set; }

    [DataMember]
    public int TotalMiss { get; set; }

    [DataMember]
    public int NumberFFA { get; set; }

    [DataMember]
    public int NumberDuel { get; set; }

    [DataMember]
    public int NumberPrecise { get; set; }

    [DataMember]
    public int NumberFast { get; set; }

    [DataMember]
    public int NumberEndless { get; set; }




}