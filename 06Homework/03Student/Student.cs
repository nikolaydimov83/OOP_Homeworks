using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Student
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 10 || value > 90) 
                {
                    throw new ArgumentOutOfRangeException("Invalid age!Should be between 10 and 90");
                }
                this.age = value; 
            }
        }

        public int FaculltyNumber
        {
            get { return this.facultyNumber; }
            set 
            {
                if (value.ToString().Length < 7)
                {
                    throw new ArgumentOutOfRangeException("Invalid Number ID - must be at least 7 digits");
                }
                this.facultyNumber = value; 
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public IList<int> Marks
        {
            get { return this.marks; }
            set 
            {
                if (value.Max() > 6 || value.Min() < 2)
                {
                    throw new ArgumentOutOfRangeException("Invalid marks - the list contains marks greater than 6 or less than 2");
                }
                this.marks = value; 
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public Student(string firstName, string lastName, int age,
                       int facultyNumber, string phone, string email,
                       IList<int> marks, int groupNumber) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FaculltyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;        
        }
        public override string ToString()
        {
           return string.Format("{0}, {1}, {2}, {3},{4}, {5}, {6}, {7}",
                                this.firstName, this.LastName, this.Age,this.FaculltyNumber,
                                this.GroupNumber,this.Phone,this.Email,this.Marks.Average()); 
        }
    }
}
