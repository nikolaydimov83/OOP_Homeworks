using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person nikolay = new Person("Nikolay", 20, "");
            Person petar = new Person("Petar", 20);
            Console.WriteLine(petar.ToString());
            Console.WriteLine(nikolay.ToString());

        }
    }
}
