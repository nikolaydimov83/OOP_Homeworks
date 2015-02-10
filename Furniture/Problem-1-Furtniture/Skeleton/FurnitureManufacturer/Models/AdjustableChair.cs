using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair:Chair,IAdjustableChair
    {
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            :base(model, material, price, height, numberOfLegs)
        {

        }
        public void SetHeight(decimal height)
        {
            if (height<=0)
            {
                throw new ArgumentException("Invalid Height");
            }
            this.height = height;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
