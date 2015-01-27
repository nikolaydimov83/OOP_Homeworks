using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03StudentClass
{
   
    
    class Program
    {
        private static void PropertyCahnged(object sender,
        PropertyChangedEventArgs eventArgs)
        {
           

        }

        static void Main(string[] args)
        {
            Student student = new Student("Pesho", 18);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyChanged,eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Maria";
            student.Age = 21;
           
          
        }
        
    }
}
