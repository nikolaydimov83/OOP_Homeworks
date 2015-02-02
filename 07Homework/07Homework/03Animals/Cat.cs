using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    abstract class Cat:Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender) 
        {
        
        }
        public virtual void EatMilk() 
        {
            Console.WriteLine("Mmmmm, So delicious..");
        }      
        
        
    }
}
