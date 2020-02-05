using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;

/// <summary>
/// Summary description for FFAGameMode
/// </summary>
public class MultyPlayerShootOut : GameLogic
{
    
    public List<Target> targets { get; set; }
    public TargetFactory targetFactory { get; set; }

    const int maxNumberOfTargetsAtTheSameTime = 10;
    public MultyPlayerShootOut(int seed = 0 , TargetTypes allowed = TargetTypes.None) :base (seed, allowed)
    {
        targets = new List<Target>();
        targetFactory = new TargetFactory();
        targetFactory.TargetTypesAllowed = this.TargetTypesAllowed;
        targetFactory.random = new Random(this.seed);
        
        targetFactory.actieTargets = this.targets;
        publisher = new Publisher();
    }


    public MultyPlayerShootOut(MultyPlayerShootOut copy) :base()
    {
        targets = new List<Target>(copy.targets);
        TargetTypesAllowed = copy.TargetTypesAllowed;
        players = new Dictionary<string, Shooter>(copy.players);

        this.seed = copy.seed;
        this.TargetTypesAllowed = copy.TargetTypesAllowed;
        this.publisher = copy.publisher;

        //Target factory
        targetFactory = new TargetFactory();
        targetFactory.actieTargets = this.targets;
        targetFactory.random = new Random(this.seed);
        targetFactory.TargetTypesAllowed = copy.TargetTypesAllowed;
    }

 

    public override void start()
    {

        initPublisher();
        fillTagets();
        publisher.NotifyGameStart();
        timer.Start();

    }

   

    public void fillTagets()
    {
        while (targets.Count < maxNumberOfTargetsAtTheSameTime)
        {
            targets.Add(this.targetFactory.getNextTarget());
        }

        publisher.UpdateTargets(targets);
    }


    public override void submitHit(string username, int x, int y)
    {
        Shooter player = players[username];
        lock (targets)
        {
            foreach (Target t in targets)
            {
                if (t.TryToHit(player, x, y))
                {
                    fillTagets();
                    return;
                }

            }
            player.numbeerOfMisses++;
        }
    }
}