using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02LaptopShop
{
    class Battery
    {
        private string batteryType;
        private int batteryNumberOfCells;
        private double batteryAmperage;
        private double batteryLife;

        string BatteryType
        {
            get { return this.batteryType; }
            set 
            {
            if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery type");
                }
            this.batteryType = value;
            }
        }

        int BatteryNumberOfCells
        {
            get { return this.batteryNumberOfCells; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Number of cells cannot be bellow zeo");
                }
                this.batteryNumberOfCells = value;
            }
        }

        double BatteryAmperage
        {
            get { return this.batteryAmperage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery amperage cannot be bellow zeo");
                }
                this.batteryAmperage = value;
            }
        }

        double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be bellow zeo");
                }
                this.batteryLife = value;
            }
        }

        public Battery(string batteryType, int batteryNumberOfCells, double batteryAmperage, double batteryLife) 
        {
            this.BatteryType = batteryType;
            this.BatteryNumberOfCells = batteryNumberOfCells;
            this.BatteryAmperage = batteryAmperage;
            this.BatteryLife = batteryLife;
        }

        public override string ToString()
        {

            return string.Format("Bateery Type: {0}, Cells: {1}, Amperage: {2}, Life:{3}",
            this.BatteryType, this.BatteryNumberOfCells, this.BatteryAmperage, this.BatteryLife);


        }
    }
}
