using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Shapes
{
    class Circle:IShape
    {
        private double radius;
        public Circle(double radius) 
        {
            this.Radius = radius;
        }
        public double Radius 
        {
            get { return this.radius;}
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Radius cannot be below zero");
                }
                this.radius = value;
            }
        }

        public double  CalculateArea() 
        {
            return Math.PI * radius * radius;
        }
        public double CalculatePerimeter() 
        {
            return 2 * Math.PI * radius;
        }
    }
}
