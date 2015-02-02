using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class __Test
    {
        static void Main(string[] args)
        {
            Project newProject = new Project("TestProject", new DateTime(2011,11,25), "detail");
            newProject.CloseProject();

            List<Employee> listEmps = new List<Employee>();
            SalesEmployee sales = new SalesEmployee(1201, "Selski", "Selskia", 3300, Department.Sales);
            Developper dev = new Developper(1202, "Devcho", "Devchev", 5900, Department.Production);
            listEmps.Add(dev);
            listEmps.Add(sales);
            dev.AddProject("C--", new DateTime(2011, 5, 5), "Details");
            sales.AddSale("Tapo productche", new DateTime(2011, 5, 5), 15298);
            Manager manager = new Manager(1200, "Менджо", "Менджев", 1500, Department.Marketing, listEmps);

            List<Employee> emps = new List<Employee>{ dev, sales, manager };
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
