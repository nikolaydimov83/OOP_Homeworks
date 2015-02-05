using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    public enum CustomerType{Individual, Company}
    //В една реална банкова система със сигуроност би имало един клас Customer и два класа, които го наследяват Individual и Company,
    //поради факта, че имат различни типове полета, но тъй като тук в класа няма нужда от друго поле освен име - за опростеност го правя 1
    //с тип на клиента като Property
    public class Customer
    {
        private string name;
        private CustomerType customerType;

        public Customer(string name, CustomerType customerType) 
        {
            this.Name = name;
            this.CustomerType = customerType;
        }

        public string Name 
        {
            get { return this.name; }
            set 
            {
                this.name = value;
            }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set
            {
                this.customerType = value;
            }
        }
    }
}
