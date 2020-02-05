using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMProClient.AIMProService;
using AIMProClient.Controllers;

namespace AIMProClient.Crosshairs
{
    class Piercing:Crosshair
    {
        public Piercing(GameController gc):base(gc)
        {

        }

        public override void submitHit(int x, int y)
        {
            List<Target> pomTargets=base.gameController.targets;
            int countHits = 0;
            double unitx = base.gameController.canvas.Width / 1000.0;
            double unity = base.gameController.canvas.Height / 1000.0;

            foreach (Target t in pomTargets)
            {
                t.radius = (unitx <= unity) ? (int)(t.radius * unitx) : (int)(t.radius * unity);

                if (base.isInCircle(x, y, t.x, t.y, t.radius))
                {
                    if (t.type == TargetTypes.Shielded)
                    {
                        countHits += 2;
                    }
                    else
                    {
                        countHits++;
                    }
                }
            }

            if(countHits==0)
            {
                CommunicationLayer.Instance.submitHit(x, y);
            }
            else
            {
                while(countHits>0)
                {
                    CommunicationLayer.Instance.submitHit(x, y);
                    countHits--;
                }
            }

        }

    }
}
