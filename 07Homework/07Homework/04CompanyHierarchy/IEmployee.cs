using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    enum Department {Production, Accounting, Sales, Marketing }
    interface IEmployee
    {
        decimal Salary  { get; set; }
        Department Department { get; set; }
        decimal CalculateSalaryEfficiency();
    }
}
