using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    class Discipline
    {
        private string name;
        internal int numberOfTeachers;
        internal List<Student> disciplineStudents = new List<Student>();
        

        public Discipline(string name) 
        {
            if (AllDisciplines.allDisciplines.Where(x=>x.Name==name).Count()>0)
            {
                throw new ArgumentException("This discipline already exists");
            }
            this.Name = name;
            AllDisciplines.allDisciplines.Add(this);
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
                throw new ArgumentException("Discipline name cannot be empty");
                }                
                this.name = value;
            }
        }

        public List<Teacher> DisciplineTeachers
        {
            get
            {
                return AllDisciplines.disciplineTeachers[this.Name];
            }
            
        }

        public List<Student> DisciplineStudents 
        {
            get 
            {
                return this.disciplineStudents;
            }
        }
    }
}
