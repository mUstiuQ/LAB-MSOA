using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_MSOA_REFACUT
{
    public class Student:Persoana //clasa studentu care mosteneste clasa persoana
    {
        private byte an;
        private byte[] note = new byte[5];

        public byte AnStudiu => an;
        public string NumeStudent => nume;

        public Student(byte an, byte[] note, string nume, byte varsta)
            :base(nume, varsta)
        {
            this.an = an;
            this.note = note;
        }

        public float Medie()
        {
            float suma = 0;
            foreach (byte n in note)
                suma += n;
            return suma / note.Length;
        }

        public string AfisareStudent()
        {
            return $"{nume} | Varsta: {varsta} | An: {an} | Medie: {Medie():0.00}";
        }
    }
}
