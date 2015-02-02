using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    class Kitten:Cat
    {
        
        public Kitten(string name, int age)
            : base(name, age, Gender.Female) 
        {
        
        }
        public override void EatMilk() 
        {
            Console.WriteLine("Kittens preffer fish to Milk");
        }
        public override void ProduceSound() 
        {
            Console.WriteLine("Miauuuuuuuuuuuu! I am a kitten");
        }
    }
}
