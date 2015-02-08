using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Homework
{
    class Tester
    {
        static void Main(string[] args)
        {
            Payment payment1 = new Payment("Duhalka", 105.23m);
            Payment payment2 = new Payment("Shtrakalka", 92.23m);

            List<Payment> listOfPayments = new List<Payment>();

            listOfPayments.Add(payment1);
            listOfPayments.Add(payment2);

            Customer pesho = new Customer("Pesho", "Petrov", "Ivanov", 78524, "18 Atanas Velkov str.", "0899335452", "pesho@abv.bg", listOfPayments,CustomerType.Golden);
            Customer gosho = (Customer)pesho.Clone();
            gosho.ID = 68524;

            Payment payment3 = new Payment("Mandarsalka", 100m);
            Payment payment4 = new Payment("Shmarkalka", 10m);

            List<Payment> listOfPaymentsNew = new List<Payment> {payment3,payment4 };
            gosho.Payments = listOfPaymentsNew;
            Console.WriteLine(pesho.ToString());
            Console.WriteLine(gosho.ToString());
            Console.WriteLine(pesho.CompareTo(gosho));


        }
    }
}
