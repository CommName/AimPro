using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ShieldedTarget
/// </summary>
/// 
[DataContract]
public class ShieldedTarget : Target
{
    public ShieldedTarget() : base()
    {
        pointsWorth = 0;
        this.type = TargetTypes.Shielded;
    }


    public override bool TryToHit(Shooter player, int x, int y)
    {
        if (isInCircle(x, y))
        {
            Target withoutShield = new Target(this);
            
            player.numberOfHits++;
            activeTargets.Remove(this);
            activeTargets.Add(withoutShield);

            return true;
        }
        return false;
    }

}