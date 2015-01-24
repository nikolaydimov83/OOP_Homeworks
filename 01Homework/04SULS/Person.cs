using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04SULS
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid first name");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid last name");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if ((value<0))
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }

        public Person(string firstName, string lastName, int age) 
        
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

        }

        
    }
}
