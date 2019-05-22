using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Square:Rectangle
    {
        private double side; 
        public Square(double side):base(side,side)
        { }
        public Square(double side,Color color, bool filled):base(side,side,color,filled)
        {

        }
        public  double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

    }
}
