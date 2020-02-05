using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AIMProClient.DrawingStrategy
{
    interface ICursorDrawing
    {
        //abstract 
        
            void CrtajNisan(Graphics g,int cursorX,int cursorY,double percentScale, Color boja); 
    }
}
