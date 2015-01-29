using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Custom_LINQ_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>testLinqExtensions=new List<int>();
           
            testLinqExtensions.Add(1);
            testLinqExtensions.Add(2);
            testLinqExtensions.Add(3);
            testLinqExtensions.Add(6);

            IEnumerable<int> newListToTest = testLinqExtensions.WhereNot(x => x == 1);
            newListToTest = newListToTest.Repeat(3);
                       
            foreach (var item in newListToTest)
            {
                Console.WriteLine(item);
            }

            List<string> strings = new List<string>();
            strings.Add("Ala");
            strings.Add("Bala");
            strings.Add("effect");
            strings.Add("Butterfly");

            List<string> suffixes = new List<string>();
            suffixes.Add("la");
            suffixes.Add("ala");         
            suffixes.Add("fly");
            IEnumerable<string> testSuffixes = strings.WhereEndsWith<string>(suffixes);

            foreach (var item in testSuffixes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
