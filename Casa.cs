using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5._2
{
    class Casa: Imobil
    {
        public int numarCamere { get; set; }
        public double suprafata { get; set; }
        public Casa (int numarCamere, double suprafata) : base()
        {
            this.numarCamere = numarCamere;
            this.suprafata = suprafata;
        }
        public string afiseazaInformatii()
        {
            return "Casa: " + "\nNumar Camere: " + this.numarCamere + "\nSuprafata: " + this.suprafata;
        }
    }
}
