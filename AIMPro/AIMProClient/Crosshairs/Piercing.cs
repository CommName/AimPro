using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;
using AIMProClient.Controllers;

namespace AIMProClient.Crosshairs
{
    class Piercing : Crosshair
    {
        public Piercing(GameController gc) : base(gc)
        {

        }
        public override void submitHit(int x, int y)
        {
            int countHits = 0;
            double unitx = base.gameController.canvas.Width / 1000.0;
            double unity = base.gameController.canvas.Height / 1000.0;

            List<Target> hitsTargets = new List<Target>();

            foreach (var pointTarget in base.gameController.pointsTargets)
            {
                int targetRadius = (unitx <= unity) ? (int)(pointTarget.Item2.radius * unitx) : (int)(pointTarget.Item2.radius * unity);

                if (base.isInCircle(x, y, (int)pointTarget.Item1.X, (int)pointTarget.Item1.Y, targetRadius,0))
                {
                    if (pointTarget.Item2.type == TargetTypes.Shielded)
                    {
                        countHits++;
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
                foreach (Target t in hitsTargets)
                {
                    CommunicationLayer.Instance.submitHit(t.x, t.y);
                }
            }

        }

    }
}