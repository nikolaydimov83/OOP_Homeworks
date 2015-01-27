using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03Generic_List;

namespace _04VersionAttribute
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> a = new GenericList<int>();

            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(false);
            string final = "Version";
            foreach (VersionAttribute attr in allAttributes)
            {
                final= attr.Major.ToString()+"."+attr.Minor.ToString();
            }

            Console.WriteLine("Version:" + final);
        }
    }
}
