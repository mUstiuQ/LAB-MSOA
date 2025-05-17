using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_MSOA_REFACUT
{
    class ComparaMedie:IComparer<Student> //clasa pt comparare a mediei
    {
        public int Compare(Student x, Student y)
        {
            return x.Medie().CompareTo(y.Medie());
        }
    }
}
