using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    class DepositAccount:Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            :base(customer, balance, monthlyInterestRate)
        {

        }

        public void WithdrawMoney (decimal moneyToWithdraw)
        {
            this.balance -= moneyToWithdraw;
        }

        public override decimal CalculateInterest(decimal months) 
        {
            if (this.balance > 1000)
            {
                return base.CalculateInterest(months);
            }
            else
            {
                return this.Balance;
            }
        }
    }
}
