using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int exCounter = 0;
            do
            {
                exCounter = 0;
                try
                {
                    Console.WriteLine("Please add numerator and denominator for the first fraction");
                    int numerator = int.Parse(Console.ReadLine());
                    int denominator = int.Parse(Console.ReadLine());

                    Fraction first = new Fraction(numerator, denominator);

                    Console.WriteLine("Please add numerator and denominator for the second fraction");
                    numerator = int.Parse(Console.ReadLine());
                    denominator = int.Parse(Console.ReadLine());

                    Fraction second = new Fraction(1, 4);

                    Fraction sum = (first + second);
                    Console.WriteLine(sum.ToString());
                }
                catch
                {
                    exCounter++;
                }
            } 
            while (exCounter != 0);
        }
    }
}
