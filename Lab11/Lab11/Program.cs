using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Time[] times = new Time[10];
            for (int i = 0; i < times.Length; i++)
                times[i] = new Time();
            foreach(Time  time in times)
            {
                Console.WriteLine(time);
            }
            Array.Sort(times);
            Console.WriteLine(); Console.WriteLine();
            foreach (Time time in times)
            {
                Console.WriteLine(time);
            }

        }
    }
}
