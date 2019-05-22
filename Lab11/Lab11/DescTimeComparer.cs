using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class DescTimeComparer : IComparer<Time>
    {
        public int Compare(Time x, Time y)
        {
            return -x.CompareTo(y);
        }
    }
}
