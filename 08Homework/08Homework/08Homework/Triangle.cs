using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Shapes
{
    class Triangle:BasicShape
    {
        private double secondSide;

        public Triangle(double width, double heigth, double secondSide)
            : base(width, heigth) 
        {
            this.SecondSide = secondSide;
        }

        public double SecondSide
        {
            get { return this.secondSide; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Second side cannot be less than zero");
                }
                this.secondSide = value;
            }  
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Heigth)/2d;
        }

        public override double CalculatePerimeter()
        {
            double thirdSide;
            double widthPartThirdSide;
            double widthPartSecondSide;

            widthPartSecondSide = Math.Sqrt((secondSide * secondSide) + (Heigth * Heigth));
            widthPartThirdSide = this.Width - widthPartSecondSide;
            thirdSide = Math.Sqrt((widthPartThirdSide * widthPartThirdSide) + (Heigth * Heigth));

            return thirdSide + secondSide + Width;
        }
    }
}
