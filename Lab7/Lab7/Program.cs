using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Title = "Laborator7";
            MyArray mA = new MyArray(10);
            for (int i = 0; i <10; i++)
                mA.Add(i * i);
            mA[3] += 5;
            Console.WriteLine(mA);
            //toate aparitiile
           // mA.Remove(14);

                        
           

        }
    }
}
