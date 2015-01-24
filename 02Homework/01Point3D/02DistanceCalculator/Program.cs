using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _02DistanceCalculator;

namespace _01Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D.StartingPoint.X = 1;

            Point3D firstPoint = new Point3D(2, 2, 2);
            Point3D secondPoint = new Point3D(3, 3, 3);
            Console.WriteLine(Point3D.StartingPoint.ToString());
            Console.WriteLine(DistanceCalculator.calculateDistance(firstPoint, secondPoint));
        }
    }
}
