using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Class target is responcible for:
/// to check if the player hit the target 
/// updated players points
/// updated targets that player can see (from list<target> active targets)
/// IT IS NOT RESPONCIBLE TO ADD NEXT TARGET FROM QUEUE
/// </summary>
/// 

[DataContract]
public class Target
{
    [DataMember]
    public int radius { get; set; }
    [DataMember]
    public int x { get; set; }
    [DataMember]
    public int y { get; set; }
    [DataMember]
    public TargetTypes type { get; set; }

    public List<Target> activeTargets { get; set; }
    public int pointsWorth { get; set; }

    public bool isInCircle(int x, int y)
    {
        return (((x - this.x) * (x - this.x) + (y-this.y)*(y-this.y))< radius * radius);
    }

    public Target()
    {
    }



    public bool TryToHit(Shooter player, int x, int y)
    {
        if (isInCircle(x, y))
        {
            activeTargets.Remove(this);
            player.points += this.pointsWorth;
            return true;
        }
        return false;
    }

}