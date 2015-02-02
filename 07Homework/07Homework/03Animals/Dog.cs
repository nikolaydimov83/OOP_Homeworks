using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    class Dog:Animal
    {
        public Dog(string name, int age, Gender gender) 
            : base(name, age, gender) 
        {
        
        }
        public void WagTail() 
        {
            Console.WriteLine("Tail wagging..");
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Bau Bau!");
        }
    }
}
