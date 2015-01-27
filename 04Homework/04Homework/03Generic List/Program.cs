using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList <int> a = new GenericList <int>();
            
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);

            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);

            a.Add(1);
            a.Add(-2);
            a.Add(3);
            a.Add(15);

            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);

            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            Console.WriteLine();

          

            a.InsertAtIndex(1, 5);
            a.InsertAtIndex(0, 5);
            a.InsertAtIndex(21, 5);

            a.FindIndexByValue(1);
            bool b=a.Contains(88);
            int c=a.Max<int>();
            Console.WriteLine(a.ToString());
        }
    }
}
