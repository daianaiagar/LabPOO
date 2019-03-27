using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    class Program
    {
       /**
        * Creati un TAD cu numele Huge, care implementeaza conceptul de numar natural mare.
        * 
        * 
        * */
        static void Main(string[] args)
        {
            Huge h1 = new Huge(123456789);
            Huge h2 = new Huge("231231231231231231231231231231232");
              Huge h3 = new Huge("349249023849023849023849023842903482930482934823904823904823094823094");
            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);
            Huge a = new Huge("234234234234234234");
            Huge b = new Huge(1);
            Console.WriteLine(a+b);
            Console.WriteLine(a*b);
            Console.WriteLine(a.Power(10));

            



            Console.ReadKey();
        }
    }
}
