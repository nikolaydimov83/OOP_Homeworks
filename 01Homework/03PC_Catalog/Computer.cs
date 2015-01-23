using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03PC_Catalog
{
    class Computer
    {
        private string name;
        private Component[] components;
        private decimal price;

        public string Name 
        {
            get { return this.name; }
            set {
                if (String.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
                }
        }

        public Component[] Components
        {
            get { return this.components; }
            set { this.components = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                this.price = calculatePrice(components);
            }
        }
        public Computer(string name, Component[] components) 
        {
            this.Name = name;
            this.Components = components;
            this.Price = this.price;
            
        }
        private decimal calculatePrice(Component[] componets)
        {
            decimal price = 0;
            foreach (var item in componets)
            {
                price += item.Price;
            }
            return price;
        }
        public void PrintComp() 
        {
            Console.WriteLine("Computer name: " + this.Name);
            foreach (var item in this.Components)
            {
                Console.WriteLine(" Component name: " + item.Name, "Component price: " + item.Price);
            }
            Console.WriteLine("Total price: " + this.Price);
        }
    }
}
