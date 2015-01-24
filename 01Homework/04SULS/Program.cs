using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _04SULS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nakovCourse = new List<string>();
            nakovCourse.Add("OOP");
            SenTrainer nakov = new SenTrainer("Svetlin", "Nakov", 34, nakovCourse);
            nakov.CreateCourse("KPK");
            nakov.DeleteCourse("KPK");
            Console.WriteLine();

            GraduateStudent kaskata = new GraduateStudent("Kaskata", "Kaskov", 18, 231, 5.32);
            OnSiteStudent pesho = new OnSiteStudent("Pesho", "Peshev", 20, 251, 5.1, "OOP");
            OnlineStudent gosho = new OnlineStudent("Ivan", "Ivanov", 21, 253, 5.5, "OOP");
            DropOutStudent mincho = new DropOutStudent("Mincho", "Minchev",17,200,5.11,"Alcohol");
            pesho.MakeVisit();
            pesho.MakeVisit();
            pesho.MakeVisit();
            Console.WriteLine(pesho.NumberOfVisits);

            List<Person> finalTestList = new List<Person>();

            finalTestList.Add(nakov);
            finalTestList.Add(kaskata);
            finalTestList.Add(pesho);
            finalTestList.Add(gosho);
            finalTestList.Add(mincho);
            List<CurrentStudent> result = new List<CurrentStudent>();

            foreach (var person in finalTestList)
            {
                if (person.GetType() == typeof(CurrentStudent) || person.GetType() == typeof(OnlineStudent) || person.GetType() == typeof(OnSiteStudent))
                {
                    result.Add((CurrentStudent)person);
                }
            }

            IEnumerable<CurrentStudent> finalResult = result.OrderBy(student => student.AvgGrade);

            
            Console.WriteLine();

        }



     
    }
}
