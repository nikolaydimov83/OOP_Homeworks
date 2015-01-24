using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class Student:Person
    {
        private int number;
        private double avgGrade;

        public int Number
        {

            get { return this.number; }
            set
            {
                
                this.number= value;
            }

        }

        public double AvgGrade
        {

            get { return this.avgGrade; }
            set
            {

                this.avgGrade = value;
            }

        }



    public Student(string firstName, string lastName, int age, int number, double averageGrade):base(firstName, lastName, age)
    {
        this.AvgGrade = averageGrade;
        this.Number = number;
    
    }
    }
}
