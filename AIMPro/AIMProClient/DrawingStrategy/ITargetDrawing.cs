using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AIMProClient.DrawingStrategy
{
    abstract class ITargetDrawing
    {
        public virtual void CrtajMetu(Graphics g, int x, int y, int r, Color boja) {
            Brush brush = new SolidBrush(boja);
            g.FillEllipse(brush, x - r, y - r, 2 * r, 2 * r);
        }

        public Color generisiInverznuBoju(Color boja)
        {
            Color inverznaBoja = new Color();
            inverznaBoja = Color.FromArgb(255 - boja.R, 255 - boja.G, 255 - boja.B);
            return inverznaBoja;
        }
    }
}
