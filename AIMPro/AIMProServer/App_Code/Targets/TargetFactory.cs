﻿using System;
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

    protected TargetTypes CastSNumerToTargetType(int number)
    {
        switch (number)
        {
            case 0: return TargetTypes.None;
            case 1: return TargetTypes.Moving;
            case 2: return TargetTypes.Shielded;
            case 3: return TargetTypes.Boost;
            case 4: return TargetTypes.Negative;
            case 5: return TargetTypes.Child;
            default: return TargetTypes.None;
        }

    }

    public Target getNextTarget()
    {
        Target newTarget;


        TargetTypes typeOfNewTarget = CastSNumerToTargetType(random.Next(0, 5));

        switch (typeOfNewTarget)
        {
            case TargetTypes.None: { newTarget = new Target(); break; }
            case TargetTypes.Moving: { newTarget = new Target(); break; }
            case TargetTypes.Shielded: { newTarget = new Target(); break; }
            case TargetTypes.Boost: { newTarget = new Target(); break; }
            case TargetTypes.Negative: { newTarget = new Target(); break; };
            case TargetTypes.Child: { newTarget = new Target(); break; }
            default: { { newTarget = new Target(); break; } }
        }

        newTarget.type = typeOfNewTarget;
        newTarget.activeTargets = actieTargets;
        newTarget.radius = 10;
        newTarget.x = random.Next() % winSizeX;
        newTarget.y = random.Next() % winSzieY;

        return newTarget;
    }
}