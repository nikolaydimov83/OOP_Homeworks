﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Furniture:IFurniture
    {
        private string model;
        private string material;
        protected decimal price;
        protected decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }
        
        public string Model
        {
            get { return this.model; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3) 
                {
                    throw new ArgumentException("Argument cannot be null or empty and must be at least 3 symbols");
                }
                this.model = value; 
            }
        }

        public string Material
        {
            get { return this.material; }
            private set 
            {
                this.material = Enum.Parse(typeof(MaterialType), value,true).ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Price cannot be below 0");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set             
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be below 0");
                }
                this.height=value;
            }
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }     
    }
}
