using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Student
{
    class Program
    {
        static void Print(IEnumerable<Student> listToDisplay) 
        
        {
            foreach (var item in listToDisplay)
            {
                Console.WriteLine(item.ToString());
            }
           
        } 
        static void Main(string[] args)
        {
            List<Student> testList=new List<Student> 
            {
                new Student ("Pesho","Agoncev",20,12341456,"02 896 615 658","pesho@abv.bg",new List<int>{2,2,6,3,6},2,"Mediocre")
                ,new Student ("Gosho","Zetov",25,1234156,"+3592 896 616 758","gosho@abv.bg",new List<int>{2,3,3,4,5},2, "First Class")
                ,new Student ("Mrancho","Bonchev",22,1234164,"+359 2 896 785 758","mranchev@abv.bg",new List<int>{6,6,6,6,6},1, "First Class")
                ,new Student ("Zubar","Zubarov",23,1234175,"359 887 785 758","zubara@abg.bg",new List<int>{2,2,2,6,6},1, "Mediocre")
            };
            
            var groupNumberTwo=testList.Where(x=>x.GroupNumber==2).OrderBy(x=>x.FirstName);

            Print(groupNumberTwo);
            Console.WriteLine();

            var firstNameBeforeLastName = testList.Where(x => (x.FirstName.CompareTo(x.LastName) == -1));
            Print(firstNameBeforeLastName);
            Console.WriteLine();
                
            var ageBetween = testList.Where(x => (x.Age > 18 && x.Age < 24)).Select(x => new { x.FirstName, x.LastName, x.Age });
            foreach (var item in ageBetween)
              {
                  Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
              }

            var orderByName = testList.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Console.WriteLine();
            Print(orderByName);

            var emailAbv = testList.Where(x => x.Email.EndsWith("@abv.bg"));
            Console.WriteLine();
            Print(emailAbv);

            var phoneStarts = testList.Where(x => x.Phone.StartsWith("02") || x.Phone.StartsWith("+3592") || x.Phone.StartsWith("+359 2"));
            Console.WriteLine();
            Print(phoneStarts);

            var atLeastOneSix=testList.Where(x=>x.Marks.Contains(6));
            Console.WriteLine();
            Print(atLeastOneSix);

            var exactlyTwoTwos = testList.Where(x => x.Marks.Count(y=>y==2)==2);
            Console.WriteLine();
            Print(exactlyTwoTwos);

            var enlisted2014 = testList.Where(x => x.FaculltyNumber.ToString()[5] == '1' && x.FaculltyNumber.ToString()[6] == '4');
            Console.WriteLine();
            Print(enlisted2014);

            var tryGroupBy = from student in testList
                                 group student by student.GroupName into g
                                 orderby g.Key
                                 select g;

            foreach (var group in tryGroupBy)
            {
                var groupKey = group.Key;
                Console.WriteLine(groupKey);
                foreach (var groupedItem in group)
                {
                    Console.WriteLine("     "+groupedItem.ToString());
                }
            }

            List<StudentSpecialty> listofSpecialities = new List<StudentSpecialty>() 
            { 
            new StudentSpecialty("Web Developer",12341456),
            new StudentSpecialty("PHP Developer",12341456),
            new StudentSpecialty("C# Developer",12341456),
            new StudentSpecialty("QA engineer",12341456),

            new StudentSpecialty("Javascript guru",1234156),
            new StudentSpecialty("Ruby master",1234156),
            new StudentSpecialty("Fortran developer",1234156),

            new StudentSpecialty("C# Developer",1234175),
            new StudentSpecialty("QA engineer",1234175),
            new StudentSpecialty("Javascript guru",1234175),
            new StudentSpecialty("Ruby master",1234175)
            };

            var joinedList=listofSpecialities.Join(testList, x => x.FacultyNumber, y => y.FaculltyNumber, (facultyNums, students) => new { facultyNums.SpecialityName, facultyNums.FacultyNumber, students.FirstName, students.LastName });
            var joinedListToDisplay=joinedList.ToList();
            foreach (var item in joinedListToDisplay)
            {
                Console.WriteLine(item.FacultyNumber + " " + item.SpecialityName + " " + item.FirstName + " " + item.LastName);
            }

        }
    }
}
