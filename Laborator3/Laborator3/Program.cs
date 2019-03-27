using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator3
{
    class Program
    {
        static void Main()
        {
            Numar n = new Numar(435345345);
            Console.WriteLine(n.Hex);
            Console.WriteLine(n.ConvertToBase(2));
            Console.WriteLine(n.Add(new Numar(34)).Value);
            Console.WriteLine(n.Div(new Numar(10)).Value);
            Console.ReadKey();
           
            return;
        }
    }
}
