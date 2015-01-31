using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    public static class AllDisciplines
    {
        internal static List<Discipline> allDisciplines = new List<Discipline>();
        internal static Dictionary<string, List<Teacher>> disciplineTeachers = new Dictionary<string, List<Teacher>>();
        public static int CalculateNumberOfCourses(string name) 
        {
            int numberOfCourses=0;
            foreach (var item in disciplineTeachers)
            {
                foreach (var teacher in item.Value)
                {
                    if (teacher.Name == name) 
                    {
                        numberOfCourses++;
                    }
                }
            }
            return numberOfCourses;
        }

 
    }
}
