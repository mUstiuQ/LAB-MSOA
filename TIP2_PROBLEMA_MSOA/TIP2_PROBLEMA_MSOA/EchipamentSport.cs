using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TIP2_PROBLEMA_MSOA
{

    //la toate ex cu propertygrind avem nevoie de displayname pt o aranjare mai usoara si musai sa folosim get si set ca altfel da eroare si nu stim ce are 
   public class EchipamentSport
    {
        [DisplayName("Cod Echipament")]
        public string Cod { get; set; }

        [DisplayName("Producator")]
        public string Producator { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Descriere")]
        public string Descriere { get; set; }

        [DisplayName("Numar Bucati")]
        public int NrBucati { get; set; }

        [DisplayName("Pret")]
        public decimal Pret
        {
            get => _pret;
            set => _pret = value >= 0 ? value : 0; // verifica ca pretul sa nu fie negativ
        }
        private decimal _pret;

        [DisplayName("Categorie")]
        public string Categorie { get; set; } // cele 3 categroii: intor, ciclism, fotbal

    }
}
