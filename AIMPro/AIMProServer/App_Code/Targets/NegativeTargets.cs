using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for NegativeTargets
/// </summary>
/// 
[DataContract]
public class NegativeTargets : Target
{
    public NegativeTargets() : base()
    {
        pointsWorth = -2;
        this.type = TargetTypes.Negative;
    }
}