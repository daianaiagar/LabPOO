using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Triangle
    {
        Point p1, p2, p3;
        double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.X - p1.X) * (p2.X - p1.X));
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            double l1, l2, l3;

            l1 = Distance(p1, p2);
            l2 = Distance(p2, p3);
            l3 = Distance(p1, p3);
            if (l1 + l2 > l3 && l3 + l2 > l1 && l1 + l3 > l2)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;

            }
            else
                Console.WriteLine("Asta nu e triunghi!");
        }
        public double Perimetru
        {
           
           get
            {
                double l1, l2, l3;
                l1 = Distance(p1, p2);
                l2 = Distance(p2, p3);
                l3 = Distance(p1, p3);

                return l1 + l2 + l3;
            }
        }
        public double Arie
        {
            get
            {
                double l1, l2, l3;
                l1 = Distance(p1, p2);
                l2 = Distance(p2, p3);
                l3 = Distance(p1, p3);
                double p = (l1 + l2 + l3) / 2;
                return Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
            }
        }

    }
}
