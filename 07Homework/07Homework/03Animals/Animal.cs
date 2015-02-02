using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Animals
{
    public enum Gender{Male=1, Female=2}
    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public abstract void ProduceSound();
    }
}
