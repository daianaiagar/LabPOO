using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        { 
            Circle c = new Circle(4);
            Console.WriteLine(c);
            Circle d = new Circle(4.5, Color.Galben, true);
            Console.WriteLine(d);
            Shape e = new Circle(4.5, Color.Roz, true);
            Circle f = new Circle(color : Color.Roz, r: 4.5, filled: false);
            Console.WriteLine(e.ShapeColor);
            Rectangle r = new Rectangle(color: Color.Roz, height: 300, width: 400, filled: true);
            Console.WriteLine(r);

        }
    }
}
