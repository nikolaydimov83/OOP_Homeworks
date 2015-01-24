using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01Point3D;
using _02DistanceCalculator;



 

namespace _03Paths
{
    class Path3D
    
    {
        private List<Point3D> pathSequence;
        public List<Point3D> PathSequence 
        {
            get { return this.pathSequence; }
            set { this.pathSequence = value; }
        }

        public Path3D(List<Point3D> pathSequence) 
        {
            this.PathSequence = pathSequence;
        }
      
        public int NumberOfPointsInPath() 
        {
            return this.PathSequence.Count();
        }

        public double CalculateDistance() 
        {
            double totalDistanceCovered=0;
            for (int i = 1; i <= pathSequence.Count-1; i++)
            {
               
                    totalDistanceCovered += DistanceCalculator.calculateDistance(pathSequence[i - 1], pathSequence[i]);
               
            }
            return totalDistanceCovered;
        }

    }
}
