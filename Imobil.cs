using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5._2
{
    class Imobil
    {
        public int numarCamere { get; set; }
        public double suprafata { get; set; }

        public Imobil()
        {
            numarCamere = 0;
            suprafata = 0;
        }

        public string afiseazaInformatii()
        {
            return "Impobil: " + numarCamere + "\nSuprafata: " + suprafata;
        }

        public int afiseazaInformatii(int numarCamere)
        {
            return numarCamere;
        }

        public double afiseazaInformatii(double suprafata)
        {
            return suprafata;
        }
       public Imobil(int numarCamere, double suprafata)
        {
            this.numarCamere = numarCamere;
            this.suprafata = suprafata;
          

        }
    }
}
