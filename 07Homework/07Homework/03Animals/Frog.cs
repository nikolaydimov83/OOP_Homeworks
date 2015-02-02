using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    class Frog:Animal
    {
        public Frog(string name, int age, Gender gender)
            : base(name, age, gender) 
        {
        
        }
        public void EatFly() 
        {
            Console.WriteLine("Mmmmm, So delicious..");
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Kva Kva!");
        }
    }
}
