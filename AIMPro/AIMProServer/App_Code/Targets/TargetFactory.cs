using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TargetFactory
/// </summary>
public class TargetFactory
{
    Random random;

    public TargetFactory()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    Target getNextTarget()
    {
        Target newTarget;

        newTarget = new Target();

        return newTarget;
    }
}