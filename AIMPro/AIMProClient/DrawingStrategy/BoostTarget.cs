using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AIMProClient.DrawingStrategy
{
    class BoostTarget : ITargetDrawing
    {
        public override void CrtajMetu(Graphics g, int x, int y, int r, Color boja)
        {
            base.CrtajMetu(g,x,y,r,boja);
            CrtajPlus(g, x, y, r, boja);
        }

        private void CrtajPlus(Graphics g, int x, int y, int r, Color boja)
        {
            Pen greenPen = new Pen(generisiInverznuBoju(boja), r / 4);
            greenPen.Alignment = PenAlignment.Center;
            int duzina = r / 2;
            g.DrawLine(greenPen, x, y - duzina, x, y + duzina);
            g.DrawLine(greenPen, x - duzina, y, x + duzina, y);
        }

    }
}
