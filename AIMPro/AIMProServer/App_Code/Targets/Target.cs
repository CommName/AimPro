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
[KnownType(typeof(NegativeTargets))]
[KnownType(typeof(ShieldedTarget))]
[KnownType(typeof(BoostTarget))]
[KnownType(typeof(ChildTargets))]
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
        radius = 50;
        pointsWorth = 10;
        type = TargetTypes.None;
    }

    public Target(Target target) : this()
    {
        this.radius = target.radius;
        this.x = target.x;
        this.y = target.y;
        this.activeTargets = target.activeTargets;

    }


    virtual public bool TryToHit(Shooter player, int x, int y)
    {
        if (isInCircle(x, y))
        {
            activeTargets.Remove(this);
            player.points += this.pointsWorth;
            player.numberOfHits++;
            player.callback.EarnedPoints(player.points,pointsWorth);
            return true;
        }
        return false;
    }

}