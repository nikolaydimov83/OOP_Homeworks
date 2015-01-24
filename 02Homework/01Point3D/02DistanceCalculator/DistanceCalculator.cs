using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01Point3D;

namespace _02DistanceCalculator
{
    class DistanceCalculator
    {

        public static double calculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
           
            return Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) 
                + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) 
                + (firstPoint.Y - secondPoint.Z) * (firstPoint.Y - secondPoint.Z));
        }
    }
}
