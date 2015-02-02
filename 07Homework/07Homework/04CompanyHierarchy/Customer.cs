using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    class Customer:Person,ICustomer
    {
        private decimal netPurchasedAmount;
        public Customer(int id, string firstName, string lastName, decimal netPurchasedAmount) : base(id, firstName, lastName)
        {
            this.NetPurchasedAmount = netPurchasedAmount;
        }
        public decimal NetPurchasedAmount 
        {
            get { return this.netPurchasedAmount; }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Purchased amount cannot be negative");
                }
                this.netPurchasedAmount = value;
            }
        }
    }
}
