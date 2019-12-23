using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for MatchStatistics
/// </summary>
[DataContract]
public class MatchStatistics
{

    [DataMember]
    public int TypeOfGame { get; set; }

    [DataMember]
    public int NumberOfMiss { get; set; }

    [DataMember]
    public int NumberOfHits { get; set; }

    [DataMember]
    public int NumberOfPoints { get; set; }

    [DataMember]
    public int MatchRank { get; set; }


}