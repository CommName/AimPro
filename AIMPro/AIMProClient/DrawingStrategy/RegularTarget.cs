using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AIMProClient.DrawingStrategy
{
    class RegularTarget : ITargetDrawing
    {
        public RegularTarget() : base()
        {
            this.boja = Color.FromArgb(255, 0, 0);
        }
        public override void CrtajMetu(Graphics g)
        {
            base.CrtajMetu(g);
        }
    }
}
