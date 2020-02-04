using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TargetFactory
/// </summary>
public class TargetFactory
{
    public Random random { get; set; }
    public List<Target> actieTargets { get; set; }
    public const int winSizeX = 1000;
    public const int winSzieY =  1000;

    public TargetTypes TargetTypesAllowed { get; set; }


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


        TargetTypes typeOfNewTarget = CastSNumerToTargetType(random.Next(0, 6));

        switch (typeOfNewTarget)
        {
            case TargetTypes.None: { newTarget = new Target(); break; }
            case TargetTypes.Shielded: { newTarget = new ShieldedTarget(); break; }
            case TargetTypes.Boost: { newTarget = new BoostTarget(); break; }
            case TargetTypes.Negative: { newTarget = new NegativeTargets(); break; };
            case TargetTypes.Child: { newTarget = new ChildTargets(random); break; }
            default: { { newTarget = new Target(); break; } }
        }
        newTarget.type = typeOfNewTarget;
        newTarget.activeTargets = actieTargets;
        newTarget.x = random.Next() % winSizeX;
        newTarget.y = random.Next() % winSzieY;

        return newTarget;
    }
}