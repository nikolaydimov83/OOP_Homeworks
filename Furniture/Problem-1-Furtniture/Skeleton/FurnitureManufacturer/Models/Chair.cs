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

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            :base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set { this.numberOfLegs = value; }
        }
        public override string ToString()
        {
            return base.ToString()+String.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}
