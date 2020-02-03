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
        public BoostTarget() : base()
        {
            this.boja = Color.FromArgb(0, 0, 255);
        }
        public override void CrtajMetu(Graphics g)
        {
            base.CrtajMetu(g);
            CrtajPlus(g);
        }

        private void CrtajPlus(Graphics g)
        {
            Pen greenPen = new Pen(generisiInverznuBoju(), r / 4);
            greenPen.Alignment = PenAlignment.Center;
            int duzina = r / 2;
            g.DrawLine(greenPen, x, y - duzina, x, y + duzina);
            g.DrawLine(greenPen, x - duzina, y, x + duzina, y);
        }

    }
}
