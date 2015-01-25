using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                    throw new ArgumentNegativeSqrtException("You cannot enter negative number");
                Console.WriteLine(Math.Sqrt(number));
            }

            catch (FormatException)
            {
                Console.WriteLine("The number you enetered is in invalid format. You should enter positive integer number between 0 and {0}", int.MaxValue);
            }

            catch (ArgumentException)
            
            {
                Console.WriteLine("You have entered invalid argument for calculation. Please, make sure you entered positive number");
            }

            finally 
            {
                Console.WriteLine("Goodbye!");
            }
            
        }
    }
}
