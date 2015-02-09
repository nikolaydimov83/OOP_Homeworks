using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Chair:Furniture,IChair
    {
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set { this.numberOfLegs = value; }
        }
    }
}
