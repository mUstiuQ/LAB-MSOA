using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2_ptP2
{
    public class Angajat
    {
        public string Nume { get; set; }
        public string CNP { get; set; }
        public int ZileLucrate { get; set; }
        public string Departament { get; set; }
        public double SalariuPeZi { get; set; }

        public DateTime DataNasterii
        {
            get
            {
                string an = CNP.Substring(1, 2);
                string luna = CNP.Substring(3, 2);
                string zi = CNP.Substring(5, 2);
                int anInt = int.Parse(an);
                int prefix = CNP[0] == '1' || CNP[0] == '2' ? 1900 : 2000;
                return new DateTime(prefix + anInt, int.Parse(luna), int.Parse(zi));
            }
        }

        public int Varsta => DateTime.Now.Year - DataNasterii.Year -
                             (DateTime.Now.DayOfYear < DataNasterii.DayOfYear ? 1 : 0);
    }

}



