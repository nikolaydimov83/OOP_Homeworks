using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class OnSiteStudent : CurrentStudent
    {
        private int numberOfVisits;
        string currentCourse;

        

        public int NumberOfVisits
        {
            get { return this.numberOfVisits; }
            set { this.numberOfVisits = value; }
        }

        public OnSiteStudent(string firstName, string lastName, int age, int number, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, number, averageGrade, currentCourse)
        {


        }


        public void MakeVisit()
        {
            this.numberOfVisits++;
        }

    }
}