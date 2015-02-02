using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private const decimal minSalary=340;
        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName) 
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        { 
            get { return this.salary;} 
            set 
            {
                if (value<minSalary)
                {
                    throw new ArgumentOutOfRangeException("Invalid Salary entered");
                }
                this.salary=value;
            } 
        }

        public Department Department
        {
            get { return this.department; }
            set
            {
                this.department = value;
            }
        }
        public abstract decimal CalculateSalaryEfficiency();
    }
}
