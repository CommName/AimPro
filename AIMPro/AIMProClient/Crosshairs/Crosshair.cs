using AIMProClient.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.Crosshairs
{
    public class Crosshair
    {
        public GameController gameController { get; set; }

        public Crosshair()
        {

        }

        public Crosshair(GameController controller): this()
        {
            gameController = controller;
        }

        virtual public void submitHit(int x,int y)
        {
            CommunicationLayer.Instance.submitHit(x, y);
        }

        public bool isInCircle(int x, int y, int x1, int y1, int radius)
        {
            return (((x - x1) * (x -x1) + (y - y1) * (y - y1)) < radius * radius);
        }
    }
}
