using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphics;
        private double hddInGB;
        private string screen;
        private decimal price;
        private Battery bateria;

        string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                throw new ArgumentException("Invalid laptop model");
                }
                this.model = value;

            }
        }

        string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid laptop manufacturer");
                }
                this.manufacturer = value;

            }
        }

        string Processor
        {
            get { return this.processor; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid laptop processor");
                }
                this.processor = value;

            }
        }

        int RAM
        {
            get { return this.ram; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid laptop RAM");
                }
                this.ram = value;

            }
        }

        string Graphics
        {
            get { return this.graphics; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid laptop graphics");
                }
                this.graphics = value;

            }
        }

        double HDDInGB
        {
            get { return this.hddInGB; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid laptop HDD");
                }
                this.hddInGB = value;

            }
        }

        string Screen
        {
            get { return this.screen; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid laptop screen");
                }
                this.screen = value;

            }
        }

        decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid laptop price");
                }
                this.price = value;

            }
        }

        Battery Bateria
        {
            get { return this.bateria; }
            set
            {
               
                this.bateria = value;

            }
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price,  Battery bateria):this(model, price)
        {
            this.Bateria= bateria;
      
        }

        public Laptop(string model, decimal price, Battery bateria, string processor):this(model,price,bateria)
            
        {
            this.processor = processor;

        }

        public override string ToString()
        {
           
                return string.Format("Model: {0}, Price: {1}, Battery: {2}, Processor:{3}",
                this.Model, this.Price, this.Bateria.ToString(), this.Processor);
            

        }
    }
}
