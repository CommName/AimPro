using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class target is responcible for:
/// to check if the player hit the target 
/// updated players points
/// updated targets that player can see (from list<target> active targets)
/// IT IS NOT RESPONCIBLE TO ADD NEXT TARGET FROM QUEUE
/// </summary>
public class Target
{
    protected int radius;
    protected TargetTypes type;
    protected int x;
    protected int y;
    protected List<Target> activeTargets;
    protected int pointsWorth;

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
            lock (activeTargets) {
                activeTargets.Remove(this);
            }
            player.points += this.pointsWorth;
            return true;
        }
        return false;
    }

}