using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queque
{
    class Program
    {
        static void Main(string[] args)
        {
            Queque q = new Queque();
            q.Enqueque(1);
            q.Enqueque(2);
            q.Dequeque();
            q.Enqueque(3);
            Console.WriteLine(q.Count);
            return;
        }
    }
}
