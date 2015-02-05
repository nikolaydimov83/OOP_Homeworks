using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02BankOfKurtovoKonare
{
    class TestClasses
    {
        static void Main(string[] args)
        {
            Customer company = new Customer("Shmenti Kapeli OOD", CustomerType.Company);
            Customer individual = new Customer("Sulyo Pulev", CustomerType.Individual);

            MortgageAccount mortgageCompany = new MortgageAccount(company, 1000, 0.01m);
            MortgageAccount mortgageIndividual = new MortgageAccount(individual, 1000, 0.01m);

            DepositAccount depositCompany = new DepositAccount(company, 900, 0.01m);
            DepositAccount depositIndividual = new DepositAccount(individual, 1001, 0.01m);

            LoanAccount loanCompany = new LoanAccount(company, 900, 0.01m);
            LoanAccount loanIndividual = new LoanAccount(individual, 1001, 0.01m);

            Console.WriteLine("Test CalculateInterest for Mortgage Companies");
            Console.WriteLine(mortgageCompany.CalculateInterest(13));
            Console.WriteLine(mortgageCompany.CalculateInterest(11));

            Console.WriteLine("Test CalculateInterest for Mortgage Individuals");
            Console.WriteLine(mortgageIndividual.CalculateInterest(5));
            Console.WriteLine(mortgageIndividual.CalculateInterest(7));

            Console.WriteLine("Test CalculateInterest for Deposit Companies and Individuals");
            Console.WriteLine(depositCompany.CalculateInterest(1));
            Console.WriteLine(depositIndividual.CalculateInterest(1));

            Console.WriteLine("Test CalculateInterest for Loan Companies and Individuals");
            Console.WriteLine(loanCompany.CalculateInterest(2));
            Console.WriteLine(loanCompany.CalculateInterest(3));
            Console.WriteLine(loanIndividual.CalculateInterest(3));
            Console.WriteLine(loanIndividual.CalculateInterest(4));

            Console.WriteLine("Test Deposit - Withdraw");
            Console.WriteLine(depositCompany.Balance);
            depositCompany.WithdrawMoney(100);
            Console.WriteLine(depositCompany.Balance);
            depositCompany.DepositMoney(100);
            Console.WriteLine(depositCompany.Balance);

            

        }
    }
}
