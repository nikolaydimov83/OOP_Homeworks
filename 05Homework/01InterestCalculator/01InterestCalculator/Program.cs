using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01InterestCalculator
{
    class Program
    {
        public static double GetSimpleInterest(double sum, double interest, double years) 
        
        {
            
            return sum * (1 + interest * years);
        }

        public static double GetCompoundInterest(double sum, double interest, double years)
        {
            
            return ((double)sum * (Math.Pow(((1 + (interest / 12))),(years*12))));
        }

        /*public static void Printer(InterestCalculator calculator)
        {
            double result = calculator.IntCalc();
        }*/

        
        static void Main(string[] args)
        {
            
            Func<double, double, double, double> CalculateInterest =Program.GetSimpleInterest;
            Func<double, double, double, double> CalculateCompund= Program.GetCompoundInterest;

            InterestCalculator calculateFirstExample = new InterestCalculator(500, 0.056, 10, CalculateCompund);
            InterestCalculator calculateSecondExample = new InterestCalculator(2500, 0.072, 15, CalculateInterest);
            
            double n = calculateFirstExample.IntCalc(500, 0.056, 10);
            
            double m = calculateSecondExample.IntCalc(2500, 0.072, 15);

            Console.WriteLine("Compund interest: {0}", n);
            Console.WriteLine("Simple interest: {0}", m);

            
            
        }
    }
}
