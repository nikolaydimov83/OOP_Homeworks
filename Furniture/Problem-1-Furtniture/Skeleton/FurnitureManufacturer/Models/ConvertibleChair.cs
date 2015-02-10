using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    enum ChairState 
    {
    Converted,Normal
    } 
    class ConvertibleChair:Chair,IConvertibleChair
    {
        private bool isConverted;
        private decimal normalHeight;
        private ChairState chairState;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs, bool isConverted)
            :base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = isConverted;
        }

        public ChairState ChairState 
        {
            get { return this.chairState; }
            set { this.chairState = value; }
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set 
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (isConverted == false)
            {
                this.normalHeight = this.height;
                this.height = 0.10m;
                this.chairState = ChairState.Converted;
            }
            else 
            {
                this.height = normalHeight;
                this.chairState = ChairState.Normal;
            }
            this.isConverted = !this.isConverted;
        }
        public override string ToString()
        {
            return base.ToString()+string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
