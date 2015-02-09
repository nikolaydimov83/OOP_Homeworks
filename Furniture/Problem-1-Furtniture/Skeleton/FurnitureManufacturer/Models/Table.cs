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
            get { return this.width * this.Height; }
        }
    }
}
