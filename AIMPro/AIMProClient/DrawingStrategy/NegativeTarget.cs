using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AIMProClient.DrawingStrategy
{
    class NegativeTarget : ITargetDrawing
    {
        public NegativeTarget() :base()
        {
            this.boja = Color.FromArgb(221, 160, 221);
        }
        public override void CrtajMetu(Graphics g)
        {
            base.CrtajMetu(g);
            CrtajMinus(g);
        }

        private void CrtajMinus(Graphics g)
        {
            Pen greenPen = new Pen(generisiInverznuBoju(), r / 4);
            greenPen.Alignment = PenAlignment.Center;
            int duzina = r / 2;
            g.DrawLine(greenPen, x - duzina, y, x + duzina, y);
        }
    }
}
