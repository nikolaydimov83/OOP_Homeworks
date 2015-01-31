using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    class ClassOfStudents:List<Student>
    {
        private List<Teacher> listOfClassTeachers = new List<Teacher>();
        private string classIdentifier;
        private string details;

        public ClassOfStudents(List<Teacher> listOfClassTeachers, string classIdentifier, string details)
            :base()
            {
                this.ListOfClassTeachers = listOfClassTeachers;
                this.ClassIdentifier = classIdentifier;
                this.Details = details;
            }

        public ClassOfStudents(List<Teacher> listOfClassTeachers, string classIdentifier)
            : base()
        {
            this.ListOfClassTeachers = listOfClassTeachers;
            this.ClassIdentifier = classIdentifier;
            
        }
        public List<Teacher> ListOfClassTeachers 
        {
            get { return this.listOfClassTeachers; }
            set { this.listOfClassTeachers = value; }
        }

        public string ClassIdentifier 
        {
            get { return this.classIdentifier; }
            set { this.classIdentifier = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

    }
}
