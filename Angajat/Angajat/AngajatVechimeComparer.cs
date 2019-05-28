using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    class AngajatVechimeComparer:IComparer<Angajat>
    {
         public int Compare(Angajat left, Angajat right)
        {
            Vechime leftVechime = left.Vechime();
            Vechime rightVechime = right.Vechime();
            if (leftVechime.Ani < rightVechime.Ani)
                return -1;
            else
                  if (leftVechime.Ani > rightVechime.Ani)
                return 1;

            if (leftVechime.Luni < rightVechime.Luni)
                return -1;
            else
                if (leftVechime.Luni > rightVechime.Luni)
                return 1;

            return 0;

        }
    }
}
