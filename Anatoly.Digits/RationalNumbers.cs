using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Digits
{
    internal class RationalNumbers
    {
        private int _numerator;
        private int _denominator;

        public RationalNumbers()
        {

        }
        public RationalNumbers(int numerator, int denominator = 1)
        {
            _numerator = numerator;
            _denominator = denominator;
        }



        public static RationalNumbers operator +(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            if (firstFraction._denominator == secondFraction._denominator)
            {
                return new RationalNumbers {_numerator=firstFraction._numerator+secondFraction._numerator, _denominator=firstFraction._denominator};
            }

            return new RationalNumbers
            {
                _numerator = firstFraction._numerator * secondFraction._denominator + secondFraction._numerator * firstFraction._denominator,
                _denominator = firstFraction._denominator * secondFraction._denominator
            };
        }

        public static RationalNumbers operator -(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            if (firstFraction._denominator == secondFraction._denominator)
            {
                return new RationalNumbers { _numerator = firstFraction._numerator - secondFraction._numerator, _denominator = firstFraction._denominator };
            }

            return new RationalNumbers
            {
                _numerator = firstFraction._numerator * secondFraction._denominator - secondFraction._numerator * firstFraction._denominator,
                _denominator = firstFraction._denominator * secondFraction._denominator
            };
        }


        public static bool operator >(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return firstFraction._numerator * secondFraction._denominator > secondFraction._numerator * firstFraction._denominator;
        }

        public static bool operator <(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return firstFraction._numerator * secondFraction._denominator < secondFraction._numerator * firstFraction._denominator;
        }

        public static bool operator >=(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return firstFraction._numerator * secondFraction._denominator >= secondFraction._numerator * firstFraction._denominator;
        }

        public static bool operator <=(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return firstFraction._numerator * secondFraction._denominator <= secondFraction._numerator * firstFraction._denominator;
        }

        public static RationalNumbers operator ++(RationalNumbers Fraction)
        {
            Fraction._numerator += Fraction._denominator;
            return Fraction;
        }

        public static RationalNumbers operator --(RationalNumbers Fraction)
        {
            Fraction._numerator -= Fraction._denominator;
            return Fraction;
        }

        public static RationalNumbers operator *(RationalNumbers Fraction, int number)
        {
            Fraction._numerator *= number;
            return Fraction;
        }

        public static RationalNumbers operator *( int number,RationalNumbers Fraction)
        {
            Fraction._numerator *= number;
            return Fraction;
        }

        public static RationalNumbers operator *(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {

            return new RationalNumbers
            {
                _numerator = firstFraction._numerator * secondFraction._numerator,
                _denominator = firstFraction._denominator * secondFraction._denominator
            };
        }

        public static RationalNumbers operator /(RationalNumbers Fraction,int number )
        {
            Fraction._denominator *= number;
            return Fraction;
        }

        public static RationalNumbers operator /(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return new RationalNumbers
            {
                _numerator = firstFraction._numerator * secondFraction._denominator,
                _denominator = firstFraction._denominator * secondFraction._numerator
            };
        }

        public static RationalNumbers operator %(RationalNumbers Fraction, int number)
        {
            return new RationalNumbers
            {
                _numerator = Fraction._numerator % (Fraction._denominator * number),
                _denominator = Fraction._denominator
            };
        }

        public static explicit operator float(RationalNumbers Fraction)
        {
            return ((float)Fraction._numerator / Fraction._denominator);
        }

        public static explicit operator int(RationalNumbers Fraction)
        {
            return (Fraction._numerator / Fraction._denominator);
        }

        

        public static bool operator ==(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return (firstFraction._numerator == secondFraction._numerator && firstFraction._denominator == secondFraction._denominator);
        }
        public static bool operator !=(RationalNumbers firstFraction, RationalNumbers secondFraction)
        {
            return (firstFraction._numerator != secondFraction._numerator || firstFraction._denominator != secondFraction._denominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                RationalNumbers Fraction = (RationalNumbers)obj;
                return (_numerator == Fraction._numerator) && (_denominator == Fraction._denominator);
            }
        }

        public override int GetHashCode()
        {
            return _denominator.GetHashCode() ^ _numerator.GetHashCode();
        }

    }
}
