using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Rectangle : Shape
    {
        private double width, height;
        public Rectangle()
            : this(1, 1, Color.Roz, false)
        {

        }
        public Rectangle(double width, double height)
            : this(width, height, Color.Roz, false)
        {


        }
        public Rectangle(double width, double height, Color color, bool filled)
        {
            this.width = width;
            this.height = height;
            this.ShapeColor = color;
            this.Filled = filled;
        }
        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
        public virtual  double  Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
         }
        public  virtual  double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override string ToString()
        {
            return string.Format("[W:{0},H:{1},Color:{2},Filled:{3}]", width, height, color, filled);
        }

    }
}
