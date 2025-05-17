using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_MSOA_REFACUT
{
    class ComparaNume : IComparer<Student> //clasa pentru comparare

    {
        public int Compare(Student x , Student y)
        {
            return x.NumeStudent.CompareTo(y.NumeStudent);
        }
    }
}
