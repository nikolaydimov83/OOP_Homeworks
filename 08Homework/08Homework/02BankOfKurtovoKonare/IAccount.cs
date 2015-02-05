using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    public interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal MonthlyInterestRate { get; set; }

        decimal CalculateInterest(decimal months);
        void DepositMoney(decimal moneyToDeposit);

    }
}
