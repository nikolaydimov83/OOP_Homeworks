using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01InterestCalculator
{
    class InterestCalculator
    {
        private double money;
        private double interest;
        private double years;
        private Func<double, double, double, double> intCalc;

        public double Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public double Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }

        public double Years
        {
            get { return this.years; }
            set { this.years = value; }
        }

        public Func<double, double, double, double> IntCalc
        {
            get { return this.intCalc; }
            set { this.intCalc = value; }
        }


        public InterestCalculator(double sum, double interest, double years, Func<double, double, double, double> intCalc)
        {
            this.Money = sum;
            this.Interest = interest;
            this.Years = years;
            this.IntCalc = intCalc;
        }

    }
}
