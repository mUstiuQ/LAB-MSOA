using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LAB2_MSOA_REFACUT
{

    public enum Categorie : int //enumerare pt categoriile de perosoane
    {
        Prieteni, Colegi, Rude, Diversi
    }


   public class Persoana
    {
        private int index;
        private string nume;
        private DateTime dataNasterii;
        private string telefon;
        private string adresa;
        private Categorie categorie;

        public Persoana(int index, string nume, DateTime dataNasterii, string telefon, string adresa, Categorie categorie)
        {
            this.index = index;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.telefon = telefon;
            this.adresa = adresa;
            this.categorie = categorie;
        }

        //chestiile ca browsable si description sunt pentru proprietatile din property grind , ele pot fi vizible sau ascunse

        [Browsable(false)] 
        public int Index => index;

        [Description("Numele complet al persoanei"), Category("Date personale")]
        public string Nume => nume;

        [Description("Data nasterii"), Category("Date personale")]
        public string DataNasterii => dataNasterii.ToString("dd.MM.yyyy");

        [Description("Telefon"), Category("Contact")]
        public string Telefon
        {
            get => adresa;
            set => adresa = value;
        }

        [Description("Adresa"), Category("Contact")]
        public string Adresa
        {
            get => adresa;
            set => adresa = value;
        }

        [Description("Categorie"), Category("General")]
        public Categorie Categorie
        {
            get => categorie;
            set => categorie = value;
        }

    }


}
