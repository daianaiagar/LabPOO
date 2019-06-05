using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class PeopleNameComparer:IComparer<Person>
    {
        public int Compare(Person left, Person right)
        {
            int comp1 = string.Compare(left.Name, right.Name);
            if (comp1 != 0)
                return comp1;
            else
            {
                int comp2 = string.Compare(left.Name, right.Name);
                return comp2;
            }
        }
    }
}
