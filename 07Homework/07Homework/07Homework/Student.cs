using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    class Student:Person 
    {
        private static int classNumber=0;
        private int classNumberInstance;


        public Student(string name, string details) : base(name, details) 
        {
            classNumber++;
            classNumberInstance = classNumber;
           
        }

        public Student(string name)
            : base(name)
        {
            classNumber++;
            classNumberInstance = classNumber;

        }

        public int ClassNumber
        {
            get 
            {
                
                return this.classNumberInstance; 
            }

           
        }

        public override void Enroll(string disciplineName)
        {
            int checkTimesDisciplineExists = 0;
            foreach (var discipline in AllDisciplines.allDisciplines)
            {
                if (discipline.Name == disciplineName) 
                {
                    discipline.disciplineStudents.Add(this);
                    checkTimesDisciplineExists++;
                
                }
                if (checkTimesDisciplineExists == 0) 
                {
                    throw new ArgumentException("Discipline does not exist");
                }
            }
        }
    }
}
