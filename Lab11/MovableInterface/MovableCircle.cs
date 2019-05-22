using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface
{
    class MovableCircle:IMovable
    {
        int radius;
        MovablePoint center;
        public MovableCircle(int x, int y,int radius)
        {
            center = new MovablePoint(x, y);
            this.radius = radius;

        }
        public MovableCircle(int x, int y, int speedx, int speedy, int radius)
        {
            center = new MovablePoint(x, y, speedx, speedy);
            this.radius = radius;

        }
        public override string ToString()
        {
            return $"Circle with the center : {center}";
        }
        public void MoveUp()
        {
            center.MoveUp();
        }
        public void MoveDown()
        {
            center.MoveDown();
        }
        public void MoveLeft()
        {
            center.MoveLeft();
        }
        public void MoveRight()
        {
            center.MoveRight();
        }
    }
}
