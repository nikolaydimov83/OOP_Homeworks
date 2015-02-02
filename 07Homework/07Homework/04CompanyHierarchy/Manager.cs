using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class Manager:Employee,IEmployee
    {
        private List<Employee> employeesUnderComand;
        public Manager(int id, string firstName, string lastName, 
                       decimal salary, Department department, 
                       List<Employee> employeesUnderComand)
            :base(id, firstName, lastName, salary, department)
        {
            this.EmployeesUnderComand = employeesUnderComand;
        }
        public List<Employee> EmployeesUnderComand 
        {
            get { return this.employeesUnderComand; }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("List of employyes under command cannot be empty");
                }
                this.employeesUnderComand = value;
            }
        }

        public override decimal CalculateSalaryEfficiency()
        {
            return this.Salary / (decimal)this.EmployeesUnderComand.Count;
        }
    }
}
