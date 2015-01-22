using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Homework
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        string Name 
        {
            get { return this.name; }
            set 
            { 
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name");
            }
            this.name = value;
            }
        }

        int Age
        {
            get { return this.age; }
            set
            {
                if (value<1 || value>100)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }

        string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value)==false && value.Contains('@')==false)
                {
                    throw new ArgumentException("Invalid email");
                }
                this.email = value;
            }
        }

        public Person(string name, int age) 
        
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email): this(name, age)
        {
            this.Email = email;
           
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(this.Email))
            {
                return string.Format("Name: {0}, Age: {1}, Email: {2}",
                this.Name, this.Age, "Uknown email");
            }
            else
            {
                return string.Format("Name: {0}, Age: {1}, Email: {2}",
                this.Name, this.Age, this.Email);
            }
            
        }

        
    }
}
