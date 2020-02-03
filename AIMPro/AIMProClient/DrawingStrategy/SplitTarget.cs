using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AIMProClient.DrawingStrategy
{
    class SplitTarget : ITargetDrawing
    {
        public override void CrtajMetu(Graphics g)
        {
            base.CrtajMetu(g);
            CrtajSplit(g);
        }
        private void CrtajSplit(Graphics g)
        {
            Brush brush = new SolidBrush(generisiInverznuBoju());
            int duzina = (5 * r) / 3;
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, duzina, FontStyle.Bold, GraphicsUnit.Pixel);
            g.DrawString("S", font, brush, x - (r * 4) / 5, y - (r * 9) / 10);
        }
    }
}
