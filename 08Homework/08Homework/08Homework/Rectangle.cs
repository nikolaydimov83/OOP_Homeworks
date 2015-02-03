using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Shapes
{
    class Rectangle:BasicShape
    {
        public Rectangle(double width, double heigth) : base(width, heigth) 
        {
        
        }

        public override double CalculateArea()         
        {
            return this.Width * this.Heigth;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width + this.Heigth)*2;
        }
    }
}
