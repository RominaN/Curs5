using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caine catel = new Caine();
            catel.nume = "Azorel";
            catel.varsta = 2;
            catel.CaracteristiciAnimal();
            catel.Latra();

            Pisica miaunel = new Pisica();
            miaunel.nume = "Blanosul";
            miaunel.varsta = 1;
            miaunel.CaracteristiciAnimal();
            miaunel.Miauna();


            Console.ReadKey();

        }
    }
}
