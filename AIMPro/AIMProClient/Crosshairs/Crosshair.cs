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

        public Crosshair(GameController controller) : this()
        {
            gameController = controller;
        }

        virtual public void submitHit(int x, int y)
        {

            sumbmitHitToConverse(x, y);
        }

        public bool isInCircle(int x, int y, int x1, int y1, int radiusTarget, int radiusCrosshair)
        {
            return ((Math.Pow((x - x1), 2.0) + Math.Pow((y - y1), 2.0)) <= Math.Pow((radiusCrosshair + radiusTarget), 2.0));
        }


        public void sumbmitHitToConverse(int x, int y)
        {
            double pomx = 1000.0 / this.gameController.canvas.Width;
            double pomy = 1000.0 / this.gameController.canvas.Height;
            int toSendX = (int)(x * pomx);
            int toSendY = (int)(y * pomy);
            CommunicationLayer.Instance.submitHit(toSendX, toSendY);
        }
    }
}