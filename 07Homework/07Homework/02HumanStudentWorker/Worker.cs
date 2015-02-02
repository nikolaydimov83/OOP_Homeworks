using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02HumanStudentWorker
{
    class Worker: Human
    {
        private const decimal minimumWage = 85;
        private const decimal maxWorkHours = 12;
        private decimal weekSalary; 
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                if (value < minimumWage)
                {
                    throw new ArgumentException("Invalid weekly salary. The minimum wage is at least BGN 340");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if ((value > maxWorkHours)||(value<0))
                {
                    throw new ArgumentException("Invalid weekly salary. The minimum wage is at least BGN 340");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour() 
        {
            return (this.weekSalary / (this.workHoursPerDay*5));
        }

        public override string ToString()
        {
            return String.Format(FirstName + " " + LastName + " " + WeekSalary+" "+WorkHoursPerDay+" "+this.MoneyPerHour());
        }
    }
}
