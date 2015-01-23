using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name");
                }
                this.name = value;
            }
        }

        string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Details");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if ((value<0))
                {
                    throw new ArgumentException("Invalid Price");
                }
                this.price = value;
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details):this(name,price)
        {
            this.Details = details;
            
        }
    }
}
