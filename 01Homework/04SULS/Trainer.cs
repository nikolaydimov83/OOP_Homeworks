using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class Trainer:Person
    {
        private List<string> course;
        public List<string> Course
        {

            get { return this.course; } 
            set{if (value.Count<1)
            {
                throw new ArgumentException("Invalid course");
            }
            this.course = value;
            }
        
        }

        public Trainer(string firstName, string lastName, int age, List<string> course):base(firstName, lastName, age)
    {
        this.Course = course;
    
    }
        public void CreateCourse(string courseName)
        {
            this.Course.Add(courseName);
            Console.WriteLine("New course has been created by this trainer: "+courseName);
        }
    }
}
