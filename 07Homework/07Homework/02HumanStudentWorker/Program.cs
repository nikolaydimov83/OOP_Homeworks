using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> 
            {
                new Student("Petar", "Petrov", "12345"),
                new Student("Ivaylo", "Ivanov", "12346"),
                new Student("Alex", "Petrov", "12347"),
                new Student("Marin", "Yanchev", "12345a"),
                new Student("Ivan", "Zahariev", "12345b"),
                new Student("Zaharin", "Yanachkov", "123458"),
                new Student("Zyumbyul", "Alexandrov", "123459"),
                new Student("Martin", "Yanchev", "12345c"),
                new Student("Dimitraki", "Hadjipeshovich", "12345d"),
                new Student("Manda", "Petrova", "1234510")
            };

            List<Worker> workers = new List<Worker> 
            {
                new Worker("Petar", "Petrov",240,8),
                new Worker("Kamber", "Pakov", 2400, 8),
                new Worker("Mihlyuz", "Mihlyzov", 1500, 12),
                new Worker("Dombi", "Kapinchev", 1680, 8),
                new Worker("Ivan", "Zahariev", 130, 8),
                new Worker("Zaharin", "Yanachkov", 120, 12),
                new Worker("Zyumbyul", "Alexandrov", 210, 12),
                new Worker("Martin", "Yanchev", 340, 12),
                new Worker("Dimitraki", "Hadjipeshovich", 125, 12),
                new Worker("Manda", "Petrova", 110, 8)
            };

            IEnumerable<Human> sortedStudents = students.OrderBy(x => x.FacultyNumber);
            IEnumerable<Human> sortedWorkers = workers.OrderBy(x => x.MoneyPerHour());
            var mergedList = sortedWorkers.Union(sortedStudents);
        }
    }
}
