using System.Text;
namespace ConsoleApp1
{
    internal class BouncingBall:Ball
    {
        private int speedx, speedy;
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
        public BouncingBall(int x, int y, int raza, int speedx, int speedy)
            :base(x,y,raza)
        {
            this.speedx = speedx;
            this.speedy = speedy;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Bouncing ball : [");
            sb.AppendFormat("({0},{1})- r={2}-speed=({3}, {4})", X, Y, R, speedx, speedy);
            sb.Append("]");
            return sb.ToString();

        }
        public void BounceXSpeed()
        {
            speedx = -speedx;
        }
        public void BounceYSpeed()
        {
            speedy = -speedy;
        }

    }
}