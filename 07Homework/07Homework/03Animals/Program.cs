using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] arrayOfAnnimals =
            {
            new Frog("Жабчо",1,Gender.Female),
            new Dog("Шаро",4,Gender.Male),
            new Tomcat("Томчо",2),
            new Kitten("Анджелка",3)
            };

            foreach (var animal in arrayOfAnnimals)
            {
                animal.ProduceSound();
                
            }
            double averageAge = arrayOfAnnimals.Average(x => x.Age);
            Console.WriteLine("The average age in the array is {0}", averageAge);
        }
    }
}
