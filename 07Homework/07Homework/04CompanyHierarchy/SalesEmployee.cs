using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class SalesEmployee:Employee, ISalesEmployee
    {
        private List<Sale> setOfSales=new List<Sale>();

        public SalesEmployee(int id, string firstName, string lastName,
                       decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        
        }
        public List<Sale> SetOfSales
        {
        get 
            {return this.setOfSales;}
        private set 
            {
                this.setOfSales = value;
            }
        }
        public override decimal CalculateSalaryEfficiency() 
        {
            return this.Salary / (decimal)this.setOfSales.Count;
        }

        public void AddSale(string productName, DateTime date, decimal price) 
        {
            this.setOfSales.Add(new Sale(productName, date, price));
        }
    }
}
