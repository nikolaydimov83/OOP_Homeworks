using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Table:Furniture,ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            :base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get { return this.length; }
            private set { this.length = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public decimal Area
        {
            get { return this.width * this.length; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area);
        }
    }
}
