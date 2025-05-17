using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_MSOA_REFACUT
{
    internal class Jucator
    {
        public string Nume { get; set; }
        public string Post { get; set; }
        public string CNP { get; set; }

        public Jucator(string nume, string post, string cnp)
        {
            Nume = nume;
            Post = post;
            CNP = cnp;
        }

    }
}
