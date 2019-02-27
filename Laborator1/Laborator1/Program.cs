using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(3,0);
            /*
            Console.WriteLine("({0},{1})", p1.X, p1.Y);
            p1.Rotate(180);
            Console.WriteLine("({0},{1})", p1.X, p1.Y);
            */
            Point p2 = new Point(0,4);
            Point p3 = new Point(0,0);
            Triangle t1 = new Triangle(p1,p2,p3);

            Console.ReadKey();
        }
    }
}
