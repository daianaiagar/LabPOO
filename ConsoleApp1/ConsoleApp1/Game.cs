using System;
using System.Threading;
namespace ConsoleApp1
{
    internal class Game
    {
        private int balls;
        private int width = 800;
        private int height = 600;
        private int v2;
        private Canvas c;
        public Game(int v):this(v,800,600)
        {
            this.balls = v;
        }

        internal void Play()
        {
           while(true)
            {
                c.Step();
                Thread.Sleep(1000);
                if(true)
                {
                    //break;
                }

            }
        }

        internal void Status()
        {
            Console.WriteLine(c);
        }

        /// <summary>
        /// To the windoooooooooooooooooow to the wall...
        /// Enemies on these balls.
        /// </summary>
        /// <param name="v">Number of balls</param>
        /// <param name="v1">Width of canvas</param>
        /// <param name="v2">Height of canvas</param>
        public Game(int v, int v1, int v2) 
        {
            balls = v;
            this.width = v1;
            this.height = v2;
            c= new Canvas(10, width, height);
           
            
        }

    }
}