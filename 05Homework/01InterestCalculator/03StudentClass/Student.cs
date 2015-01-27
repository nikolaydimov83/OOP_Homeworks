using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03StudentClass
{
    public delegate void ChangedEventHandler(object sender, PropertyChangedEventArgs e);
    class Student
    {
        private string name;
        private int age;
        private PropertyChangedEventArgs changeOfProperties;


        public string Name
        {
        get { return this.name; }
        set 
        {
            changeOfProperties = new PropertyChangedEventArgs(this.name, value, "Name");
            OnChanged(changeOfProperties);
            this.name = value; 
        }
        }
        public int Age
        {
            get { return this.age; }
            set 
            {
                changeOfProperties = new PropertyChangedEventArgs(this.age.ToString(),value.ToString(),"Age");
                OnChanged(changeOfProperties);
                this.age = value; 
               
                
            }
        }

        public Student(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
        public event ChangedEventHandler PropertyChanged;

        protected virtual void OnChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }

    
}
