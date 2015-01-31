using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Homework
{
    class TestTeacherAndStudent
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho Peshev");
            Student gosho = new Student("Gosho Goshev");

            Discipline math = new Discipline("Math");
            Discipline literature = new Discipline("Literature");
            gosho.Enroll("Math");
            pesho.Enroll("Math");

            Teacher nakov = new Teacher("Nako Nakov");
            Teacher takov = new Teacher("Tako Takov");
            nakov.Enroll(math.Name);
            nakov.Enroll(math.Name);

            ClassOfStudents trial = new ClassOfStudents(new List<Teacher>{nakov, takov},"7A","some details");
            
        }
    }
}
