﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    abstract class RegularEmployee:Employee
    {
        public RegularEmployee(int id, string firstName, string lastName,
                       decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        { 
        
        }
        public abstract override decimal CalculateSalaryEfficiency();
    }
}
