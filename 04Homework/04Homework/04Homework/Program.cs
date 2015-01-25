using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Location newPlanetLocation = new Location(10.3, 10.1, Planet.Mars);
            Console.WriteLine(newPlanetLocation);
        }
    }
}
