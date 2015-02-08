using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Homework
{
    class Customer : ICloneable,IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int id;
        private string permanentAddress;
        public string mobilePhone;
        private string email;
        private List<Payment> payments;

        public Customer(string firstName, string middleName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
        }

        public Customer(string firstName,
                        string middleName,
                        string lastName,
                        int id,
                        string permanentAddress,
                        string mobilePhone,
                        string email,
                        List<Payment> payments,
                        CustomerType customerType)
            : this(firstName, middleName, lastName, id)
        {
            this.PermanentAdress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string PermanentAdress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }

        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<Payment> Payments
        {
            get { return payments; }
            set { payments = value; }
        }

        private CustomerType customerType;

        public CustomerType CustomerType
        {
            get { return customerType; }
            set { customerType = value; }
        }
        public override bool Equals(object obj)
        {
            Customer customerToCompare = obj as Customer;

            if (customerToCompare == null)
            {
                return false;
            }

            if (this.id == (customerToCompare).id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            String final=String.Format(this.firstName + " " +
                                 this.middleName + " " +
                                 this.lastName + " " +
                                 this.id + " " +
                                 this.customerType + " " +
                                 this.email + " " +
                                 this.permanentAddress+" ");
            foreach (var payment in this.payments)
            {
                final = final + payment.ToString();
            }
            return final;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode() ^ firstName.GetHashCode() ^ lastName.GetHashCode() ^ middleName.GetHashCode();
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return customer1.Equals(customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(customer1.Equals(customer2));
        }



        public object Clone()
        {
            Customer clonedCustomer;
            List<Payment> clonedListOfPayment = new List<Payment>();
            foreach (var item in this.payments)
            {
                clonedListOfPayment.Add((Payment)item.Clone());
            }
            clonedCustomer = new Customer((string)this.firstName.Clone(), (string)this.middleName.Clone(), (string)this.lastName.Clone(), this.id, (string)this.permanentAddress.Clone(), (string)this.mobilePhone.Clone(), (string)this.email.Clone(), clonedListOfPayment, this.customerType);

            return clonedCustomer;
        }

        public int CompareTo(Customer other)
        {
            string thisFullname = this.firstName + this.middleName + this.lastName;
            string otherFullname = other.firstName + other.middleName + other.lastName;
            if (thisFullname != otherFullname) 
            {
                return thisFullname.CompareTo(otherFullname);
            }
            if (this.id != other.id)
            {
                return this.id.CompareTo(other.id);
            }
            return 0;
        }
    }
}
