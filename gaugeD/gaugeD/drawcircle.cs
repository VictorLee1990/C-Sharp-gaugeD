using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace gaugeD
{
    class drawcircle
    {
        float x,x1,y,y1,r;
        double distance;
        public void drawcircle_point(float x,float y,float x1,float y1)
        {
            this.x=x;
            this.x1=x1;
            this.y=y;
            this.y1=y1;
        }

        public void distanceR()
        {
            distance = Math.Pow(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2), 0.5);
            r = Convert.ToSingle(distance);
        }
        public void Redraw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, (x - r - 1), (y - r - 1), r * 2, r * 2);
        
        }
    }
}
