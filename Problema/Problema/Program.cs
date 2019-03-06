using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    class Program
    {
        static int Apa(int[] a)
        {
            int litrii = 0;
            int min = 0;
           for(int i=0;i<a.Length;i++)
                if (a[i] > 0) min = a[i];
                else 
                if (min - a[i] > 0)
                    litrii = litrii + min - a[i];

            
       
         
            return litrii;
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 3, 0, 0, 7, 4, 1, 0, 3 };
            Console.WriteLine(Apa(a));
            Console.ReadKey();

        }
    }
}
