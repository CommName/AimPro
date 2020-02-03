using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AIMProClient.DrawingStrategy
{
    class ShieldTarget : ITargetDrawing
    {
        public ShieldTarget() : base()
        {
            this.boja = Color.FromArgb(255, 255, 0);
        }
        public override void CrtajMetu(Graphics g)
        {
            RegularTarget okvir = new RegularTarget();
            okvir.x = x;
            okvir.y = y;
            okvir.r = (r * 5) / 4;
            okvir.boja = Color.FromArgb(192, 192, 192);
            okvir.CrtajMetu(g);
            base.CrtajMetu(g);
        }
    }
}
