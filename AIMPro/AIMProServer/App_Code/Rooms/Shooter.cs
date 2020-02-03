using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Shooter
/// </summary>
/// 
[DataContract]
public class Shooter
{
    [DataMember]
    public string username = "";
    [DataMember]
    public int points = 0;
    [DataMember]
    public int numberOfHits = 0;
    [DataMember]
    public int numbeerOfMisses = 0;
    [DataMember]
    public bool ready = false;
    [DataMember]
    public int elo = 0;

    public ICallBackPlayer callback; //Null when he left the room

 }