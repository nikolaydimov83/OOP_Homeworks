using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    abstract class Account:IAccount
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal monthlyInterestRate;

        public Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal MonthlyInterestRate
        {
            get { return this.monthlyInterestRate; }
            set { this.monthlyInterestRate = value; }
        }

        public virtual decimal CalculateInterest(decimal months) 
        {
            return this.balance * (1 + this.monthlyInterestRate * months);
        }

        public void DepositMoney(decimal moneyToDeposit) 
        {
            this.balance += moneyToDeposit;
        }
        
    }
}
