using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class SumComparer:IComparer
    {
        private int sumcif(int n)
        {
            int s = 0;
            while(n>0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            return s;
        }
        public int Compare(object a, object b)
        {
            int inta = (int)a;
            int intb = (int)b;
            int sumcifa = sumcif(inta);
            int sumcifb= sumcif(intb);
            if (sumcifa == sumcifb)
                return 0;
            else
                 if (sumcifa < sumcifb)
                return -1;
            else
                return 1;

        }
    }
}
