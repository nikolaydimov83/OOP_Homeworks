using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01Point3D;

namespace _03Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(2, 2, 2);
            Point3D secondPoint = new Point3D(3, 3, 3);
            Point3D thirdPoint = new Point3D(4, 4, 4);

            List<Point3D> path1 = new List<Point3D>();
            path1.Add(firstPoint);
            path1.Add(secondPoint);
            path1.Add(thirdPoint);
           

            Path3D pathOfStars = new Path3D(path1);

            Console.WriteLine(pathOfStars.NumberOfPointsInPath());
            Console.WriteLine(pathOfStars.CalculateDistance());

            Path3D newPath= Storage.readPathFromFile("C:\\path.txt");
            Storage.WritePathToFile(newPath, "C:\\path1.txt");
            Console.WriteLine();
        }
    }
}
