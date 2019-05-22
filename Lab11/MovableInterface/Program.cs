using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MovablePoint point = new MovablePoint(3, 4);
           point.MoveDown();
            Console.WriteLine(point);
            point.MoveLeft();
            Console.WriteLine(point);
            point.MoveRight();
            Console.WriteLine(point);
            point.MoveUp();
            Console.WriteLine(point);
            MoveableRectangle rect = new MoveableRectangle(3, 4, 4, 5, 1, 1);
            Console.WriteLine(rect);
            rect.MoveDown();
            Console.WriteLine(rect);
            rect.MoveUp();
            Console.WriteLine(rect);
            rect.MoveRight();
            Console.WriteLine(rect);
            rect.MoveLeft();
            Console.WriteLine(rect);
            */
            MovablePoint point = new MovablePoint(3, 4, 4, 5);
            Random rnd = new Random();
            do
            {
               
                int direction = rnd.Next() % 4;
                switch(direction)
                {
                    case 0:
                        {
                            Console.WriteLine("Up!");
                            point.MoveUp();
                        }break;
                    case 1:
                        {
                            Console.WriteLine("Down!");
                            point.MoveDown();
                        }break;
                    case 2:
                        {
                            Console.WriteLine("Right!");
                            point.MoveRight();
                        }break;
                    case 3:
                        {
                            Console.WriteLine("Left!");
                            point.MoveLeft();
                        }break;
                    
                }
                Console.WriteLine(point.ToString());
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            } while (true);
        }
    }
}
