using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.DrawingStrategy
{
    class PiercingNisan : ICursorDrawing
    {
        void ICursorDrawing.CrtajNisan(Graphics g, int cursorX, int cursorY, double percentScale, Color boja)
        {
            CrtajObicanNisan(g, cursorX, cursorY,percentScale, Color.FromArgb(255, 255, 127, 80));
            CrtajPiercing(g, cursorX, cursorY,percentScale);
        }

        private void CrtajObicanNisan(Graphics g, int cursorX, int cursorY, double percentScale, Color boja)
        {
            int duzinaKrsta = (int)(30 *percentScale);
            int poluprecnikPrstena = (int)(15 * percentScale);
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
        private void CrtajPiercing(Graphics g, int cursorX, int cursorY, double percentScale)
        {
            int duzinaKrsta =(int) ( 30 *percentScale);
            int poluprecnikPrstena = (int)(15 * percentScale);
            Brush orangeBrush = new SolidBrush(Color.FromArgb(255, 255, 127, 80));
            PointF[] nizTemena = new PointF[3];
            nizTemena[0] = new PointF(cursorX - duzinaKrsta - poluprecnikPrstena, cursorY - 3);
            nizTemena[1] = new PointF(cursorX - duzinaKrsta - poluprecnikPrstena, cursorY + 3);
            nizTemena[2] = new PointF(cursorX - duzinaKrsta - poluprecnikPrstena - 8, cursorY);//levo
            g.FillPolygon(orangeBrush, nizTemena);
            nizTemena[0] = new PointF(cursorX + duzinaKrsta + poluprecnikPrstena, cursorY - 3);
            nizTemena[1] = new PointF(cursorX + duzinaKrsta + poluprecnikPrstena, cursorY + 3);
            nizTemena[2] = new PointF(cursorX + duzinaKrsta + poluprecnikPrstena + 8, cursorY);//desno
            g.FillPolygon(orangeBrush, nizTemena);
            nizTemena[0] = new PointF(cursorX - 3, cursorY - duzinaKrsta - poluprecnikPrstena);
            nizTemena[1] = new PointF(cursorX + 3, cursorY - duzinaKrsta - poluprecnikPrstena);
            nizTemena[2] = new PointF(cursorX, cursorY - duzinaKrsta - poluprecnikPrstena - 8);//gore
            g.FillPolygon(orangeBrush, nizTemena);
            nizTemena[0] = new PointF(cursorX - 3, cursorY + duzinaKrsta + poluprecnikPrstena);
            nizTemena[1] = new PointF(cursorX + 3, cursorY + duzinaKrsta + poluprecnikPrstena);
            nizTemena[2] = new PointF(cursorX, cursorY + duzinaKrsta + poluprecnikPrstena + 8);//gore
            g.FillPolygon(orangeBrush, nizTemena);
        }
    }
}
