using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.DrawingStrategy
{
    class RegularNisan : ICursorDrawing
    {
        void ICursorDrawing.CrtajNisan(Graphics g, int cursorX, int cursorY, Color boja)
        {
            int duzinaKrsta = 20;
            int poluprecnikPrstena = 10;
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            Pen customPen = new Pen(boja, 4);
            customPen.Alignment = PenAlignment.Center;
            blackPen.Alignment = PenAlignment.Center;
            g.DrawEllipse(customPen, cursorX - poluprecnikPrstena - 1, cursorY - poluprecnikPrstena - 1, 2 * poluprecnikPrstena, 2 * poluprecnikPrstena);
            g.DrawEllipse(blackPen, cursorX - poluprecnikPrstena - 1, cursorY - poluprecnikPrstena - 1, 2 * poluprecnikPrstena, 2 * poluprecnikPrstena);
            g.DrawLine(customPen, cursorX, cursorY - duzinaKrsta, cursorX, cursorY + duzinaKrsta);
            g.DrawLine(blackPen, cursorX, cursorY - duzinaKrsta, cursorX, cursorY + duzinaKrsta);
            g.DrawLine(customPen, cursorX - duzinaKrsta, cursorY, cursorX + duzinaKrsta, cursorY);
            g.DrawLine(blackPen, cursorX - duzinaKrsta, cursorY, cursorX + duzinaKrsta, cursorY);
        }
    }
}
