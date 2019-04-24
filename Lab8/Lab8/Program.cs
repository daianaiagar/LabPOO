using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3,2);
            m1.RandomInt(10, 20);
            Matrix m2 = m1;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m1==m2);
            Console.WriteLine(m1!=m2);
            Matrix m3 = new Matrix(3, 2);
            m3.RandomInt(10, 20);
            Console.WriteLine(m3);
            Console.WriteLine(m3==m1);
            Console.WriteLine(m3!=m1);
             
          
         
            //transpusa
            /*
            Matrix t = p.Transpose(); 
            //10% 
            //Tema
            if(m1.Rare())
            {
                RareMatrix rm = new RareMatrix(t);

            }
            */


        }
    }
}
