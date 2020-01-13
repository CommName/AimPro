using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TargetFactory
/// </summary>
public class TargetFactory
{
    public Random random;
    public List<Target> actieTargets;
    public int winSizeX = 1000;
    public int winSzieY =  1000;
    public TargetFactory()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Target getNextTarget()
    {
        Target newTarget;

        newTarget = new Target();
        newTarget.activeTargets = actieTargets;
        newTarget.radius = 10;
        newTarget.x = random.Next() % winSizeX;
        newTarget.y = random.Next() % winSzieY;

        return newTarget;
    }
}