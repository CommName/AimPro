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
        public bool sectionCircle(int x, int y, int x1, int y1, int radiusBazooka ,int radiusTarget)
        {
            return ( (Math.Pow((x-x1), 2.0) + Math.Pow((y - y1), 2.0)) <= Math.Pow((radiusBazooka + radiusTarget), 2.0));
        }

        public override void submitHit(int x, int y)
        {
            double unitx = base.gameController.canvas.Width / 1000.0;
            double unity = base.gameController.canvas.Height / 1000.0;
            int radiusBazooka = (unitx <= unity) ? (int)(this.radius * unitx) : (int)(this.radius * unity);
            int countHits = 0;
            List<Target> hitsTargets = new List<Target>();

            foreach (var pointTarget in base.gameController.pointsTargets)
            {
                int targetRadius = (unitx <= unity) ? (int)(pointTarget.Item2.radius * unitx) : (int)(pointTarget.Item2.radius * unity);

                if (sectionCircle(x, y, (int)pointTarget.Item1.X,(int)pointTarget.Item1.Y,radiusBazooka,targetRadius))
                {
                    if (pointTarget.Item2.type == TargetTypes.Shielded)
                    {
                        countHits += 2;
                        hitsTargets.Add(pointTarget.Item2);
                        hitsTargets.Add(pointTarget.Item2);

                    }
                    else
                    {
                        countHits++;
                        hitsTargets.Add(pointTarget.Item2);

                    }
                }
            }

            if (countHits == 0)
            {
                base.submitHit(x, y);

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
