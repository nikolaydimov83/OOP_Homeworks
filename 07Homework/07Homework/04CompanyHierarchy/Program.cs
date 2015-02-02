using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Project newProject = new Project("TestProject", new DateTime(2011,11,25), "detail");
            newProject.CloseProject();
        }
    }
}
