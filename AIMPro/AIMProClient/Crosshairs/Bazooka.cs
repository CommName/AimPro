using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;
using AIMProClient.Controllers;

namespace AIMProClient.Crosshairs
{
    class Bazooka:Crosshair
    {
        int radius;
        public Bazooka(int radius, GameController gc):base(gc)
        {
            this.radius = radius;
        }
        public bool sectionCircle(int x, int y, int x1, int y1, int radius)
        {
            return ( (Math.Pow((x-x1), 2.0) + Math.Pow((y - y1), 2.0)) <= Math.Pow((radius + this.radius), 2.0));
        }


        public override void submitHit(int x, int y)
        {
            List<Target> pomTargets = base.gameController.targets;
            int countHits = 0;
            List<Target> hitsTargets = new List<Target>();
            foreach (Target t in pomTargets)
            {
                if (sectionCircle(x, y, t.x, t.y, t.radius))
                {
                    if (t.type == TargetTypes.Shielded)
                    {
                        countHits += 2;
                        hitsTargets.Add(t);
                        hitsTargets.Add(t);

                    }
                    else
                    {
                        countHits++;
                        hitsTargets.Add(t);

                    }
                }
            }

            if (countHits == 0)
            {
                CommunicationLayer.Instance.submitHit(x, y);
            }
            else
            {
               foreach(Target t in hitsTargets)
                {
                    CommunicationLayer.Instance.submitHit(t.x, t.y);
                }
            }

        }

    }
}
