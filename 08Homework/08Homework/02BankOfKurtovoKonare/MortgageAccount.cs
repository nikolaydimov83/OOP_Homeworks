using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    class MortgageAccount:Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {

        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.customer.CustomerType == CustomerType.Individual)
            {
                if (months<=6)
                {
                    return this.Balance;
                }
                else 
                {
                    return base.CalculateInterest(months - 6); 
                }
            }
            else
            {
                if (months > 12)
                {
                    return this.balance * ((1 + this.monthlyInterestRate * (months - 12)) + (1 + ((this.monthlyInterestRate/2m) * 12)));
                }
                else 
                {
                    return this.balance * ((1 + (this.monthlyInterestRate / 2m) * months));
                }
            }
        }
    }
}
