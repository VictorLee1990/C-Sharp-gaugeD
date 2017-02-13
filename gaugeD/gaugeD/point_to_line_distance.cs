using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaugeD
{
    class point_to_line_distance
    {
      
        double rusltDistance;
        float m,b;

        public double rusltDistance_math(float x, float y, float line_x, float line_y, float line_x1, float line_y1)
        {
            m = (line_y1 - line_y) / (line_x1 - line_x);
            b = line_y1 - (m * line_x1);
            rusltDistance = (Math.Abs((m * x) - y + b)) / (Math.Sqrt(m * m + (-1) * (-1)));
            return (rusltDistance);

        }
    }
}
