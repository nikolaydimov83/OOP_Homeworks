using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class SenTrainer:Trainer
    {
        public SenTrainer(string firstName, string lastName, int age, List<string> course):base(firstName, lastName, age,course)
    {
        
    
    }
        public void DeleteCourse(string courseName)
        {
            this.Course.Remove(courseName);
            Console.WriteLine("New course has been created by this trainer: " + courseName);
        }
    }
}
