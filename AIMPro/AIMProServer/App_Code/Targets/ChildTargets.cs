using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ChildTargets
/// </summary>
/// 
[DataContract]
public class ChildTargets : Target
{

    Target firstChild;
    Target secondChild;

    public ChildTargets() : base()
    {

    }

    public ChildTargets(Random r) : base()
    {
        firstChild = new Target();
        firstChild.x = r.Next() % TargetFactory.winSizeX;
        firstChild.y = r.Next() % TargetFactory.winSzieY;
        secondChild = new Target();
        secondChild.x = r.Next() % TargetFactory.winSizeX;
        secondChild.y = r.Next() % TargetFactory.winSzieY;
    }


    public override bool TryToHit(Shooter player, int x, int y)
    {

        if (base.TryToHit(player, x, y))
        {

            firstChild.activeTargets = this.activeTargets;

            secondChild.activeTargets = this.activeTargets;
            this.activeTargets.Add(firstChild);
            this.activeTargets.Add(secondChild);
            return true;
        }

        return false;
    }

}