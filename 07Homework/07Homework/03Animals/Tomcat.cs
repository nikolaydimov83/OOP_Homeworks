using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male) 
        {
        
        }
        public override void EatMilk() 
        {
            Console.WriteLine("Tomcats like milk very much!");
        }
        public override void ProduceSound() 
        {
            Console.WriteLine("Miauuuuuuuuuuuu! I am a Tomcat");
        }

    }
}
