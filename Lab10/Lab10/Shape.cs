using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{  enum Color {Roz,Rosu,Galben,Albastru,Negru}
    abstract class Shape
    {
        protected Color color;
        protected bool filled;
        public Shape():this(Color.Roz,false)
        {
           // color = Color.Roz;
          //  filled = false;


        }
        public Shape(Color color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public Color ShapeColor
        {
            set
            {
                color = value;
            }
            get
            {
                return color;
            }
          }
        public bool IsFilled()
        {
            return filled == true;
        }
        public bool Filled
        {
            set
            {
                filled = value;
            }
            get
            {
                return filled;
            }
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        //public abstract double ToString();
    }
}
