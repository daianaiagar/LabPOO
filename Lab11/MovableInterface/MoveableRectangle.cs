using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface
{
    class MoveableRectangle:IMovable
    {
        MovablePoint topLeft, bottomRight;
        private int xSpeed, ySpeed;
        public MoveableRectangle(int x1, int y1, int x2, int y2,int xSpeed, int ySpeed)
        {
            topLeft = new MovablePoint(x1, y1,xSpeed,ySpeed);
            bottomRight = new MovablePoint(x2, y2,xSpeed,ySpeed);
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public override string ToString()
        {
            return $"Rectangle with " +
                $"top left = {topLeft} " +
                $"bottom right ={bottomRight} " +
                $"has speed ({xSpeed},{ySpeed})";
        }
        public void MoveUp()
        {
          
            topLeft.MoveUp();
            bottomRight.MoveUp();
    }
        public void MoveDown()
        {
        
            topLeft.MoveDown();
            bottomRight.MoveDown();
        }
        public void MoveLeft()
        {
    
            topLeft.MoveLeft();
            bottomRight.MoveLeft();
        }
        public void MoveRight()
        {
           
            topLeft.MoveRight();
            bottomRight.MoveLeft();
    }
    }
}
