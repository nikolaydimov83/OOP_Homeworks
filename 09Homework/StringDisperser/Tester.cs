using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringDisperser
{
    class Tester
    {
        static void Main(string[] args)
        {
            
            StringDisperser stringDisperser = new StringDisperser("Ala", "Bala", "Portokala");
            object obj = new StringDisperser("Ala", "Bala", "Portokala");
            object obj1 = new object();
            Console.WriteLine(stringDisperser.Equals(obj));
            Console.WriteLine(stringDisperser.Equals(obj1));

            StringDisperser stringDisperser1 = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

        }
    }
}
