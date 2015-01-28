using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05omework
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder("Hello");
            String b=a.Substring(0, 2);
            Console.WriteLine(a.Length);
           a.RemoveString("Ell");
           
            String d = "abc";
            List<string> sd = new List<string>();
            sd.Add("1");
            Console.WriteLine(d);

            StringBuilder f = new StringBuilder("sdnbdaskjkds");
            List<int> k = new List<int>();
            k.Add(5);
            k.Add(6);
           f.AppendAll(k);
           
        }
    }
}
