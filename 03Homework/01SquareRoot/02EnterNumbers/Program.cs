using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int exCounter=0;
            do
            {
                try
                {
                    exCounter = 0;
                    Program.ReadNumber(100, 200);
                }

                catch
                {
                    exCounter++;
                }
            
            }
            while (exCounter!=0);
           
        }

        static int ReadNumber(int start, int end) 
        {
            int result;
            try
            {
                result = int.Parse(Console.ReadLine());
                if (result < start || result > end) 
                {
                    throw new ArgumentException("The numbered entered is larger than the upper or smaller than the lower boundary.","Out of range");
                }
                return result;
            }

            catch (ArgumentException ex) 
            {
                Console.Error.WriteLine("Error: {0}", ex.Message);
                throw;
            }

            catch (FormatException ex)
            {
                Console.Error.WriteLine("Error: {0}", ex.Message);
                throw;
            }
        }
    }
}
