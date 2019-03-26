using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class Program
    {
        static void TestStringConstructor()
        {
            Complex c = new Complex("3+2i");
            Console.WriteLine("{0} {1}", c.Re, c.Im);

        }
        static void Main(string[] args)
        {
            bool debug = true;
            if(debug)
            {
                TestStringConstructor();
            }
            Console.ReadKey();
        }
    }
}
