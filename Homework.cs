using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(5, 6);
            //Fraction f3 = new Fraction(8, 0);
            Fraction.Sum(f1, f2);
            Fraction.Multi(f1, f2);
            Fraction.Division(f1, f2);
            Fraction.Subtraction(f1, f2);   
        }
    }

    class Fraction
    {
        private int denominator;
        public int Numerator { get; set; }
        public int Denominator
        {
            get { return denominator; }

            set
            {
                denominator = value;
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                denominator = value;
            }
        }
        private double DecimalFraction//почему оно не возвращает десятичные числа?
        {
            get { return Numerator / Denominator; } 
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public static Fraction Sum(Fraction f1, Fraction f2)
        {
            int resultNum = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int resultDenom = f1.Denominator * f2.Denominator;
            Fraction result = new Fraction(resultNum, resultDenom);
            Console.WriteLine($"{f1.Numerator}/{f1.Denominator} + {f2.Numerator}/{f2.Denominator} = {result.Numerator}/{result.Denominator} (Десятичное: {result.DecimalFraction})");
            return result;
        }

        public static Fraction Multi(Fraction f1, Fraction f2)
        {
            int resultNum = f1.Numerator * f2.Numerator;
            int resultDenom = f1.Denominator * f2.Denominator;
            Fraction result = new Fraction(resultNum, resultDenom);
            Console.WriteLine($"{f1.Numerator}/{f1.Denominator} * {f2.Numerator}/{f2.Denominator} = {result.Numerator}/{result.Denominator} (Десятичное: {result.DecimalFraction})");
            return result;
        }

        public static Fraction Subtraction(Fraction f1, Fraction f2)
        {
            int resultNum = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int resultDenom = f1.Denominator * f2.Denominator;
            Fraction result = new Fraction(resultNum, resultDenom);
            Console.WriteLine($"{f1.Numerator}/{f1.Denominator} - {f2.Numerator}/{f2.Denominator} = {result.Numerator}/{result.Denominator} (Десятичное: {result.DecimalFraction})");
            return result;
        }

        public static Fraction Division(Fraction f1, Fraction f2)
        {
            int resultNum = f1.Numerator * f2.Denominator;
            int resultDenom = f1.Denominator * f2.Numerator;
            Fraction result = new Fraction(resultNum, resultDenom);
            Console.WriteLine($"{f1.Numerator}/{f1.Denominator} / {f2.Numerator}/{f2.Denominator} = {result.Numerator}/{result.Denominator} (Десятичное: {result.DecimalFraction})");
            return result;

        }

    }
}