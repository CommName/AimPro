using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for BoostTarget
/// </summary>
/// 
[DataContract]
public class BoostTarget : Target
{
    public BoostTarget() : base()
    {
        //
        // TODO: Add constructor logic here
        //
        radius = 15;
    }

    public override bool TryToHit(Shooter player, int x, int y)
    {
        this.pointsWorth = player.points / 10;
        return base.TryToHit(player, x, y);
    }
}