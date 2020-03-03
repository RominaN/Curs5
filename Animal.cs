using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5._1
{
    class Animal
    {
        public string nume;
        public int varsta;


        public void CaracteristiciAnimal()
        {
            Console.WriteLine("Name:" + nume);
            Console.WriteLine("Age:" + varsta);
        }

    }

    class Caine : Animal
    {
        public void Latra()
        {
            Console.WriteLine("Ham");
        }
    }
    class Pisica : Animal
    {

        public void Miauna()
        {
            Console.WriteLine("Miau");
        }

    }
}
