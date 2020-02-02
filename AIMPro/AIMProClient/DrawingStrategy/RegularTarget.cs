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
        public override void CrtajMetu(Graphics g, int x, int y, int r, Color boja)
        {
            base.CrtajMetu(g,x,y,r,boja);
        }
    }
}
