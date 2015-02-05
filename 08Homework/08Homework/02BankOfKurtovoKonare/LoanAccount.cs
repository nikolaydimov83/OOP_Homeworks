using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    class LoanAccount:Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {

        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.customer.CustomerType == CustomerType.Individual)
            {
                if (months<=3)
                {
                    return this.Balance;
                }
                else 
                {
                    return base.CalculateInterest(months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    return this.Balance;
                }
                else
                {
                    return base.CalculateInterest(months - 2);
                }
            }
        }
    }
}
