﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    interface IManager
    {
        List<Employee> EmployeesUnderComand{get; set;}
    }
}
