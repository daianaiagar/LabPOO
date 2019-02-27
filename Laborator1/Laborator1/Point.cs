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
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public  void Rotate(double teta)
        {
            //x1 = Rcos(alfa + teta) =R(cos alfta cos teta - sin alfa sin teta)
            //y1 = Rsin(alfa+teta) = R(sin alfa cos teta + cos alfa sin teta)
            /*
             * pi radian .....180
             *  x   ....  t
             * */
            double x1, y1;
            teta = (teta*Math.PI) / 180; 
            x1 = x * Math.Cos(teta) - y * Math.Sin(teta);
            y1 = y * Math.Cos(teta) + x * Math.Sin(teta);
            x = x1;
            y = y1;
        }



    }
}
