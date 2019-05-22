using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface
{
    class MovablePoint:IMovable
    {
        private int x, y, xSpeed, ySpeed;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return Y; }
        }
        public MovablePoint(int x, int y, int xSpeed=1,int ySpeed=1)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public override string ToString()
        {
            return $"({x},{y}) has speed ({xSpeed},{ySpeed})";
        }
        public void MoveLeft()
        {
            x -= xSpeed;
        }
        public void MoveRight()
        {
            x += xSpeed;
        }
        public void MoveUp()
        {
            y += ySpeed;
        }
        public void MoveDown()
        {
            y -= ySpeed;
        }

    }
}
