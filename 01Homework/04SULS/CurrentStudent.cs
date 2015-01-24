using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class CurrentStudent:Student
    {
        string currentCourse;
        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid student course");
                }
                this.currentCourse = value;
            }
        }
    public CurrentStudent(string firstName, string lastName, int age, int number, double averageGrade,string currentCourse):base(firstName, lastName, age,number,averageGrade)
    {
        this.CurrentCourse = currentCourse;
    
    }
    }
}
