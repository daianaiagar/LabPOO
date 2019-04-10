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
            MyArray mA = new MyArray(5);
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
                mA.Add(rnd.Next() % 100);
              
            Console.WriteLine(mA);
            mA.BubbleSort(MyArray.CompareBySum);
            Console.WriteLine(mA);
         
        

           

        
        

           
            //muta toate elementele din vector cu o pozitie la stanga.
            //mA.RotateLeft();









        }
    }
}
