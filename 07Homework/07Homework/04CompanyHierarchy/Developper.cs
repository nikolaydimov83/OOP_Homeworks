using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class Developper:RegularEmployee,IDevelopper
    {
        private List<Project> setOfProjects=new List<Project>();

        public Developper(int id, string firstName, string lastName,
                       decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        
        }
        public List<Project> SetOfProjects
        {
        get
            { return this.setOfProjects; }
        private set 
            {
                this.setOfProjects = value;
            }
        }
        public override decimal CalculateSalaryEfficiency() 
        {
            return this.Salary / (decimal)this.setOfProjects.Count;
        }

        public void AddProject(string projectName, DateTime projectStartDate, string details)
        {
            this.setOfProjects.Add(new Project(projectName,projectStartDate,details));
        }

        public override string ToString()
        {
            return String.Format(this.Id+" "+this.FirstName+this.LastName+" "+this.Salary+" "+this.Department+" "+this.SetOfProjects.Count);
        }
    }
}
