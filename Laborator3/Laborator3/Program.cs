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
            Numar n = new Numar(96112345);
            Console.WriteLine("Suma cifrelor numarului {0} este {1}",n.Value,n.SumaCifre());
            Console.WriteLine("Numarul {0} {1} este  prim",n.Value,n.EstePrim()?"":"Nu ");
            Console.WriteLine("Numarul {0} are {1} divizori",n.Value,n.NumarDivizori);
            Console.ReadKey();
            return;
        }
    }
}
