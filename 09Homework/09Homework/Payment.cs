using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Homework
{
    class Payment:ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string productName,decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return String.Format(this.productName+" "+this.price);
        }

        public object Clone()
        {
            Payment paymentToClone = new Payment((string)this.productName.Clone(), this.price);
            return paymentToClone;
        }
    }
}
