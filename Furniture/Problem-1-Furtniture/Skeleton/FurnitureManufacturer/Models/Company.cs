using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Company:ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (String.IsNullOrEmpty(value)||value.Length<5)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value; 
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set 
            {
                long registrationNumberAsLong;
                if (value.Length != 10 || long.TryParse(value, out registrationNumberAsLong) == false)
                {
                    throw new ArgumentException("Invalid registration number");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
            set { this.furnitures = value; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.First(x=>x.Model==model) ?? null;
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }
    }
}
