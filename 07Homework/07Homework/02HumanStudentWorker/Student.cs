using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02HumanStudentWorker
{
    class Student:Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName) 
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        
        {
            get { return this.facultyNumber; }
            set 
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5 || value.Length > 10) 
                {
                    throw new ArgumentException("Inavlid Faculty Number. Must be string between 5 and 10 digits/words");
                }

                this.facultyNumber=value;
            }
        }
        public override string ToString()
        {
            return String.Format(FirstName +" "+LastName +" "+FacultyNumber);
        }
    }
}
