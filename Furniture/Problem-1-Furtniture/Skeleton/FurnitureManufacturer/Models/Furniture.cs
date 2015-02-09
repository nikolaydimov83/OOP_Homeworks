using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Furniture:IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        protected decimal height;
        
        public string Model
        {
            get { throw new NotImplementedException(); }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3) 
                {
                    throw new ArgumentException("Argument cannot be null or empty and must be at least 3 symbols");
                }
                this.model = value; 
            }
        }

        public string Material
        {
            get { return this.material; }
            private set { this.material = value; }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price cannot be below 0");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set             
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be below 0");
                }
            }
        }

        
    }
}
