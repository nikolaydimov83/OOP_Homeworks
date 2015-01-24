using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Point3D
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
