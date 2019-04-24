using System.Text;
using System;
namespace ConsoleApp1
{
    internal  abstract class Ball
    {
        private int x, y;
        private int raza;
       // private int speedx, speedy;
        public Ball(int x, int y, int raza)
        {
            this.x = x;
            this.y = y;
            this.raza = raza;
            //this.speedx = speedx;
           // this.speedy = speedy;

        }
     
        #region proprietati

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int R
        {
            get
            {
                return raza;

            }
            set
            {
                raza = value;
            }
        }
        /*
        public int Speedx
        {
            get
            {
                return speedx;
            }
         
        }
        public int Speedy
        {
            get
            {
                return speedy;
            }
         
        }
        */
        #endregion
        /*
        public void BounceXSpeed()
        {
            speedx = -speedx;
        }
        public void BounceYSpeed()
        {
            speedy = -speedy;
        }
        */
        public bool CheckCollision(Ball b2)
        {
           double  dist;
            dist = Math.Sqrt((b2.X - X) * (b2.X - X) + (b2.Y - Y) * (b2.Y - Y));
            return (dist <= R + b2.R);
            
        }

    }
}