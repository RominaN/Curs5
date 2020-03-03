using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Casa cas = new Casa(10, 115.20);
            Console.WriteLine(cas.afiseazaInformatii());
           

            Apartament ap = new Apartament(2, 57.25);
            Console.WriteLine(ap.afiseazaInformatii());
            Console.ReadKey();

        }
    }
}
