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
        TargetTypes ret;
        switch (number)
        {
            case 0: ret= TargetTypes.None; break;
            case 1: ret= TargetTypes.Moving; break;
            case 2: ret= TargetTypes.Shielded; break;
            case 3: ret= TargetTypes.Boost; break;
            case 4: ret= TargetTypes.Negative; break;
            case 5: ret= TargetTypes.Child; break;
            default: return TargetTypes.None; break;
        }

        if((ret!=0) && ((ret & TargetTypesAllowed) == 0))
        {
            return CastSNumerToTargetType((++number) % 6);
        }
        return ret;

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