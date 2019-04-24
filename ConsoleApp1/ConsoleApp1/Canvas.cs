using System.Collections.Generic;
using System;
using System.Text;
namespace ConsoleApp1
{
    internal class Canvas
    {
        private readonly int MINRADIUS = 3;
        private readonly int MAXRADIUS = 25;
        private readonly int MINSPEED = 1;
        private readonly int MAXSPEED = 25;
        private int width;
        private int height;
        private List<BouncingBall> balls = new List<BouncingBall>();
        private BlackHole bH;
        public Canvas(int noOfballs,int width, int height)
        {
            this.width = width;
            this.height = height;
            Random rnd = new Random();
            bH = new BlackHole(rnd.Next(width), rnd.Next(height), rnd.Next(MINRADIUS, MAXRADIUS));
            for(int i=0;i<noOfballs;i++)
            {
                this.balls.Add(new BouncingBall(rnd.Next(width), 
                    rnd.Next(height),
                    rnd.Next(MINRADIUS, MAXRADIUS), 
                    rnd.Next(MINSPEED, MAXSPEED),
                    rnd.Next(MINSPEED,MAXSPEED)));
                   
                   
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(bH);
            foreach(var item in balls)
            {
                sb.Append(item+Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}