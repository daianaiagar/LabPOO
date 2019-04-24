using System.Text;
using System;
namespace ConsoleApp1
{
    internal class BlackHole : Ball
    {
      

        public BlackHole(int x, int y , int raza)
            :base(x,y,raza)
        {
         
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Black hole : [");
            sb.AppendFormat("({0},{1})- r={2}", X, Y, R);
            sb.Append("]");
            return sb.ToString() + Environment.NewLine;

        }
    }
}