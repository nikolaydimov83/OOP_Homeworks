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
                this.height = 0.1m;
                this.chairState = ChairState.Converted;
            }
            else 
            {
                this.height = normalHeight;
                this.chairState = ChairState.Normal;
            }
            this.isConverted = !this.isConverted;
        }
    }
}
