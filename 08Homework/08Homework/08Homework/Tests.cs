using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] arrayShapes = {new Rectangle(5,4),new Triangle(5,4,4), new Circle(5)};

            foreach (var shape in arrayShapes)
            {
                Console.WriteLine("Type: {2} Perimeter:{0} Area:{1}", shape.CalculatePerimeter(), shape.CalculateArea(),shape.GetType());
            }
        }
    }
}
