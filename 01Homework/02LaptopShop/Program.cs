using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery = new Battery("Li-Yon", 4, 5, 3.5);
            Laptop laptop = new Laptop("Lenovo Z340", 200.3m, battery,"Pentium");
            Console.WriteLine(laptop.ToString());
        }
    }
}
