using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    public abstract class Person:IPerson
    {
        private int id;
        private string firstName;
        private string lastName;
        private const int maxId=9999;
        private const int minId = 1000;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id 
        {
            get { return this.id; }
            set 
            {
                if (value < minId || value > maxId)
                {
                    throw new ArgumentOutOfRangeException("Invalid ID. Must be integer between" + minId + " and " + maxId);
                }
                this.id = value; 
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set 
            { 
                if (String.IsNullOrEmpty(value))
                {
                throw new ArgumentException("First Name cannot be empty");
                }
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set 
            {
                this.lastName = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name cannot be empty");
                }
            }
        }
        public override string ToString()
        {
            return String.Format(this.Id+" "+this.FirstName+" "+this.LastName);
        }
    }
}
