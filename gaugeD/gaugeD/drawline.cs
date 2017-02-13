using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gaugeD
{
    

    class drawline
    {
        float x2,y2,x3,y3;

        public void drawline_point(float x2,float y2,float x3,float y3)
        {
            this.x2=x2;
            this.x3=x3;
            this.y2=y2;
            this.y3=y3;
        }

        public void Redraw(Graphics g)
        {
            g.DrawLine(Pens.Black, x2, y2, x3, y3);

        }

    }
}
