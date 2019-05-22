using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Time:IComparable<Time>
    {
        private int hh;
        private int mm;
        private int ss;
        private static Random rnd = new Random();
        public Time()
        {
          
            hh = rnd.Next() % 12;
            mm = rnd.Next() % 60;
            ss = rnd.Next() % 60;

        }
        public Time(int hh, int mm, int ss)
        {
            this.hh = hh;
            this.mm = mm;
            this.ss = ss;


        }

        public int CompareTo(Time other)
        {
            if (other == null)
                return 1;
            if (this.hh < other.hh)
                return -1;
            else
                 if (this.hh > other.hh)
                return 1;
            else
                 if (this.mm > other.mm)
                return 1;
            else
                 if (this.mm < other.mm)
                return 0;
            else
                 if (this.ss > other.ss)
                return 1;
            else
                    if (this.ss < other.ss)
                return -1;
            else
                return 0;

        }
        public override string ToString()
        {
            return $"{hh}h:{mm}m:{ss}s";
        }
    }
}
