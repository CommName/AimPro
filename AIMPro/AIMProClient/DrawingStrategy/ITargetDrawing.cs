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
        public int x;
        public int y;
        public int r;
        public Color boja;


        public ITargetDrawing()
        {
            x = 0;
            y = 0;
            r = 0;
            boja = Color.FromArgb(0, 0, 0);
        }

        public virtual void CrtajMetu(Graphics g) {
            Brush brush = new SolidBrush(boja);
            g.FillEllipse(brush, x - r, y - r, 2 * r, 2 * r);
        }

        public Color generisiInverznuBoju()
        {
            Color inverznaBoja = new Color();
            inverznaBoja = Color.FromArgb(255 - boja.R, 255 - boja.G, 255 - boja.B);
            return inverznaBoja;
        }
    }
}
