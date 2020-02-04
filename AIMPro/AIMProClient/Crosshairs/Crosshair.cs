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
    }
}
