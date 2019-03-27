using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Program
    {
        /*TAD pentru stack(stiva);
         * Stack st = new Stack();
         * st.Push(1); --> introduce un element pe stiva
         * st.Push(2);
         * st.Push(3);
         * int v = st.Pop();-->elimina
         * Console.WriteLine(st.Peek());-->  intoarce  elementul din varful
         * stivei, fara a-l elimina.
         * st.Count -->numarul de elemente din stiva.
         * st.Capacity -->numarul maxim de elemente pe care le 
         * putem introduce.
         * 
         *
         * 
         * 
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Stack st = new Stack();
            for (int i = 0; i < 10; i++)
                st.Push(i);
            for (int i = 0; i < 5; i++)
                st.Pop();

            int value;
            bool result = st.TryPeek(out  value);
            Console.WriteLine(value);


           
           // st.Pop();
        }
    }
}
