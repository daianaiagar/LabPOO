using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle:Shape
    {
        private double radius;
        public override  double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override double GetPerimeter()
        {
           return  2 * Math.PI * radius;
        }
        public Circle():base(Color.Roz,false)
        {
           
        }
        public Circle(double r):base(Color.Roz,false)
        {
            radius = r;
        }
        public Circle(double r,Color color, bool filled)
            :base(color,filled)
            
        {
            radius = r;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.AppendFormat("raza:{0}-",radius);
            sb.AppendFormat("color:{0}-", color);
            sb.AppendFormat("filled:{0}", filled ? "Yes" : "No");
            sb.Append("}");
            return sb.ToString();
        }
        public double Radius
        {
            get
            {

                return radius;
            }
            set
            {
                if (radius < 0)
                {
                    // throw new NegativeRadiusException("");
                    radius = value;
                }

            }
        }



    }
}
