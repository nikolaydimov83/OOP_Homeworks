using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class AdjustableChair:Chair,IAdjustableChair
    {
        public void SetHeight(decimal height)
        {
            if (height<=0)
            {
                throw new ArgumentException("Invalid Height");
            }
            this.height = height;
        }
    }
}
