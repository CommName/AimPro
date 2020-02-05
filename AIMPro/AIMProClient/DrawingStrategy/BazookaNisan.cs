using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.DrawingStrategy
{
    class BazookaNisan : ICursorDrawing
    {
        void ICursorDrawing.CrtajNisan(Graphics g, int cursorX, int cursorY,double percentScale, Color boja)
        {
            int poluprecnikPrstena = (int)(15*percentScale);
            int velikiPoluprecnik = (int)(70 *percentScale);
            int duzinaKrsta = (int)(30 *percentScale);
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            Pen redPen = new Pen(Color.FromArgb(255, 200, 0, 0), 8);
            redPen.Alignment = PenAlignment.Center;
            blackPen.Alignment = PenAlignment.Center;
            g.DrawEllipse(redPen, cursorX - poluprecnikPrstena - 1, cursorY - poluprecnikPrstena - 1, 2 * poluprecnikPrstena, 2 * poluprecnikPrstena);
            g.DrawEllipse(blackPen, cursorX - poluprecnikPrstena - 1, cursorY - poluprecnikPrstena - 1, 2 * poluprecnikPrstena, 2 * poluprecnikPrstena);
            g.DrawEllipse(redPen, cursorX - velikiPoluprecnik - 1, cursorY - velikiPoluprecnik - 1, 2 * velikiPoluprecnik, 2 * velikiPoluprecnik);
            g.DrawEllipse(blackPen, cursorX - velikiPoluprecnik - 1, cursorY - velikiPoluprecnik - 1, 2 * velikiPoluprecnik, 2 * velikiPoluprecnik);
            g.DrawLine(redPen, cursorX, cursorY - velikiPoluprecnik - duzinaKrsta, cursorX, cursorY - velikiPoluprecnik);
            g.DrawLine(blackPen, cursorX, cursorY - velikiPoluprecnik - duzinaKrsta, cursorX, cursorY - velikiPoluprecnik);//gore
            g.DrawLine(redPen, cursorX, cursorY + velikiPoluprecnik + duzinaKrsta, cursorX, cursorY + velikiPoluprecnik);
            g.DrawLine(blackPen, cursorX, cursorY + velikiPoluprecnik + duzinaKrsta, cursorX, cursorY + velikiPoluprecnik);//dole

            g.DrawLine(redPen, cursorX - velikiPoluprecnik - duzinaKrsta, cursorY, cursorX - velikiPoluprecnik, cursorY);
            g.DrawLine(blackPen, cursorX - velikiPoluprecnik - duzinaKrsta, cursorY, cursorX - velikiPoluprecnik, cursorY);//levo
            g.DrawLine(redPen, cursorX + velikiPoluprecnik + duzinaKrsta, cursorY, cursorX + velikiPoluprecnik, cursorY);
            g.DrawLine(blackPen, cursorX + velikiPoluprecnik + duzinaKrsta, cursorY, cursorX + velikiPoluprecnik, cursorY);//desno
        }
    }
}
