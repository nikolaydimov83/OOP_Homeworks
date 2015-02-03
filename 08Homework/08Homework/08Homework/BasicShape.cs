using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Shapes
{
    abstract class BasicShape:IShape
    {
        private double width;
        private double heigth;

        public BasicShape(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width
        { 
            get 
            { 
                return this.width; 
            }

            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Width cannot be less than 0");
                }
                this.width = value;
            }
        }
        public double Heigth
        {
            get
            {
                return this.heigth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Heith cannot be less than 0");
                }
                this.heigth = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
