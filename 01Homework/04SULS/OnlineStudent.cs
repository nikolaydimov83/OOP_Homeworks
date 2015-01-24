using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class OnlineStudent:CurrentStudent
    {

        public OnlineStudent(string firstName, string lastName, int age, int number, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, number, averageGrade, currentCourse)
        {


        }

    }
}
