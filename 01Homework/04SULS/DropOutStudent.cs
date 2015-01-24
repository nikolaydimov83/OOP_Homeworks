using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class DropOutStudent:Student
    {
        string dropOutReason;
        public string DropOutReason
        {
            get { return this.dropOutReason; }
            set { this.dropOutReason = value; }
        }

        public DropOutStudent(string firstName, string lastName, int age, int number, double averageGrade, string dropOutReason)
            : base(firstName, lastName, age, number, averageGrade)
        {
            this.DropOutReason = dropOutReason;
        }
    }
}
