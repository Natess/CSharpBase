using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    internal class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator { get; set; }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0!");
                if(value < 0)
                {
                    numerator = -numerator;
                    value = -value;
                }
                denominator = value;
            }
        }

        public double DecimalValue{get => (double)numerator / denominator;}

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0!");
            this.numerator = numerator;
            if (denominator < 0)
            {
                this.numerator = -numerator;
                denominator = -denominator;
            }
            this.denominator = denominator;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            if(a.Denominator == b.Denominator)
                return new Fraction(a.numerator + b.numerator, a.denominator);
            return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            if (a.Denominator == b.Denominator)
                return new Fraction(a.numerator - b.numerator, a.denominator);
            return new Fraction(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public Fraction Simplification()
        {
            //Вычисление НОД
            var gcd = Math.Abs(GCD(numerator, denominator));
            return new Fraction(numerator/gcd, denominator/gcd);
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString() => $"{numerator}/{denominator}";
    }
}
