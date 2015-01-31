using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    abstract class Person:IEnrollable 
    {
        private string name;
        private string details;

        public Person(string name, string details)
        {
            this.Name = name;
            this.Details = details;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set 
            { 
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid argument");
                }
                this.details = value;
            }
        }
        public abstract void Enroll(string disciplineName);
    }
}
