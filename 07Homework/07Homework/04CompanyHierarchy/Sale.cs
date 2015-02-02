using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    public abstract class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price) 
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName
        {
            get { return this.productName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be empty");
                }
                this.ProductName = value; 
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value>DateTime.Now.AddDays(1))
                {
                    throw new ArgumentException("You cannot enter future date");
                }
                this.date = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }
    }
}
