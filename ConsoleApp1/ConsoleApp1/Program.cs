using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(25,1024,768);
            
            g.Play();

            g.Status();
        }
    }
}
