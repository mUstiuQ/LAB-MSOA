using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB1_MSOA_REFACUT
{
    public class Persoana //clasa persoana
    {
        protected string nume;
        protected byte varsta;

        public Persoana(string nume, byte varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }
    }
}