using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace _02FractionCalculator
{
    public struct Fraction
    {
        private BigInteger numerator;
        private BigInteger denominator;

        public BigInteger Numerator
        {
            get { return this.numerator; }
            set 
            {
                if (value > 9223372036854775807 || value < -9223372036854775808) 
                {
                    throw new ArgumentOutOfRangeException("The numerator is out of the supported range", "Numerator out of range");
                }
                this.numerator = value;
            }
        }

        public BigInteger Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value > 9223372036854775807 || value < -9223372036854775808)
                {
                    throw new ArgumentOutOfRangeException("The denominator is out of the supported range", "Denominator out of range");
                }

                if (value == 0)
                {
                    throw new ArgumentException ("Denominator cannot be zero", "Division by zero");
                }
                this.denominator = value;
            }
        }
        
        public Fraction(BigInteger numerator, BigInteger denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction ((fraction1.numerator*fraction2.denominator+fraction2.numerator*fraction1.denominator),(fraction1.denominator*fraction2.denominator));
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction ((fraction1.numerator*fraction2.denominator-fraction2.numerator*fraction1.denominator),(fraction1.denominator*fraction2.denominator));
        }

        public override string ToString()
        {
            return string.Format("{0}",(double)this.numerator/(double)this.denominator);
        }


    }
}
