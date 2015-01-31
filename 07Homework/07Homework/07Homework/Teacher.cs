using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    class Teacher:Person
    {
        private List<Discipline> disciplinesTeached = new List<Discipline>();
        public Teacher(string name) :base(name)
        {
        
        }

        public Teacher(string name, string details)
            : base(name,details)
        {

        }

        public List<Discipline> DisciplinesTeached 
        {
            get { return this.disciplinesTeached; }
        }

        public int NumberOfCourses
        {
            get 
            {
                return AllDisciplines.CalculateNumberOfCourses(this.Name); 
            }
        }

        public override void Enroll(string disciplineToEnroll)
        {

            int checkTimesDisciplineExists = 0;
            foreach (var discipline in AllDisciplines.allDisciplines)
            {
                if (discipline.Name == disciplineToEnroll)
                {
                    disciplinesTeached.Add(discipline);
                    checkTimesDisciplineExists++;
                    if (AllDisciplines.disciplineTeachers.ContainsKey(discipline.Name))
                    {
                        AllDisciplines.disciplineTeachers[discipline.Name].Add(this);
                    }
                    else 
                    {
                        AllDisciplines.disciplineTeachers.Add(discipline.Name,new List<Teacher>{this});
                    }
                }
                if (checkTimesDisciplineExists == 0)
                {
                    throw new ArgumentException("Discipline does not exist");
                }
            }
        }
        
    }
}
