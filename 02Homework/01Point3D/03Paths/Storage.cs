using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01Point3D;
using _02DistanceCalculator;

namespace _03Paths
{
    static class Storage
    {

        public static Path3D readPathFromFile(string filePlace) 
        
        {
            string[] lines = System.IO.File.ReadAllLines(filePlace);
            List<Point3D> listOfPoints = new List<Point3D>();
            foreach (var line in lines)
            {
                string[] extractCoordinates=line.Split(' ');
                Point3D temporaryPoint=new Point3D(Convert.ToDouble(extractCoordinates[0]),Convert.ToDouble(extractCoordinates[1]), Convert.ToDouble(extractCoordinates[2]));
                listOfPoints.Add(temporaryPoint);
            }
            return new Path3D(listOfPoints);
        }

        public static void WritePathToFile(Path3D path, string location)
        {

            List<string> pointsAsStrings = new List<string>();
            foreach (var point in path.PathSequence)
            {
                pointsAsStrings.Add(point.ToString());
            }

            string[] lines = pointsAsStrings.ToArray();
		 
	    
             
            System.IO.File.WriteAllLines(location, lines);
        }
            
            
    }
}
