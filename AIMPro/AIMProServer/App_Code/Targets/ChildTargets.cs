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
    Random random;
    public ChildTargets() : base()
    {
        random = new Random();
    }

    public ChildTargets(Random r) : base()
    {
        random = r;
    }


    public override bool TryToHit(Shooter player, int x, int y)
    {
        if (base.TryToHit(player, x, y))
        {
            Target firstChild = new Target();
            firstChild.x = random.Next() % 1000;
            firstChild.y = random.Next() % 1000;
            firstChild.activeTargets = this.activeTargets;
            Target secondChild = new Target();
            secondChild.x = random.Next() % 1000;
            secondChild.y = random.Next() % 1000;
            secondChild.activeTargets = this.activeTargets;
            this.activeTargets.Add(firstChild);
            this.activeTargets.Add(secondChild);
            return true;
        }

        return false;
    }

}