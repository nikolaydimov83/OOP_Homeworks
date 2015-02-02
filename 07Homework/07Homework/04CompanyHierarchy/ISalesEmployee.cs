using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    interface ISalesEmployee
    {
        List<Sale> SetOfSales { get; }
        void AddSale(string productName, DateTime date, decimal price);
    }
}
