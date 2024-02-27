using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pointer_and_counter_task.models
{
    internal class MyFractionClass
    {
        int _numerator;
        int _denominator;

        public MyFractionClass(int num,int don)
        {
            if (_denominator == 0)
            {
                throw new ArgumentException("Denominator cant be 0.");

            }
            _numerator = num;
            _denominator = don;
        }

        public int Numerator
        {
            get { return _numerator; }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cant be 0.");
                }
                _denominator = value;
            }
        }

        public static MyFractionClass Add(MyFractionClass fraction1, MyFractionClass fraction2)
        {
            int newNumerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator;
            int newDenominator = fraction1.Denominator * fraction2.Denominator;

            return new MyFractionClass(newNumerator, newDenominator);
        }

        public static MyFractionClass Subtract(MyFractionClass fraction1, MyFractionClass fraction2)
        {
            int newNumerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator;
            int newDenominator = fraction1.Denominator * fraction2.Denominator;

            return new MyFractionClass(newNumerator, newDenominator);
        }

        public static MyFractionClass Multiply(MyFractionClass fraction1, MyFractionClass fraction2)
        {
            int newNumerator = fraction1.Numerator * fraction2.Numerator;
            int newDenominator = fraction1.Denominator * fraction2.Denominator;

            return new MyFractionClass(newNumerator, newDenominator);
        }

        public static MyFractionClass Divide(MyFractionClass fraction1, MyFractionClass fraction2)
        {
            if (fraction2.Numerator == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }

            int newNumerator = fraction1.Numerator * fraction2.Denominator;
            int newDenominator = fraction1.Denominator * fraction2.Numerator;

            return new MyFractionClass(newNumerator, newDenominator);
        }
    }
}
