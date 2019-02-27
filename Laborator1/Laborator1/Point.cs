using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Point
    {
        double x, y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get;
        }
        public double Y
        {
            get;
        }
        public  void Rotate(double teta)
        {
            //x1 = Rcos(alfa + teta) =R(cos alfta cos teta - sin alfa sin teta)
            //y1 = Rsin(alfa+teta) = R(sin alfa cos teta + cos alfa sin teta)
            double alfa = Math.Asin(y / x);
            double x1, y1;
          

        }



    }
}
