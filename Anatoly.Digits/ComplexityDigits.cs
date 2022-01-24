using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Digits
{
    internal class ComplexityDigits
    {
        private int _number;

        public ComplexityDigits()
        {

        }
        public ComplexityDigits(int number)
        {
            _number = number;
        }

        public override string ToString()
        {
            return $"{_number}i";
        }
        public static ComplexityDigits operator +(ComplexityDigits firstDigit, ComplexityDigits secondDigit)
        {
            return new ComplexityDigits { _number = firstDigit._number + secondDigit._number };
        }
        public static ComplexityDigits operator -(ComplexityDigits firstDigit, ComplexityDigits secondDigit)
        {
            return new ComplexityDigits { _number = firstDigit._number - secondDigit._number };
        }
        public static ComplexityDigits operator *(ComplexityDigits firstDigit, ComplexityDigits secondDigit)
        {
            return new ComplexityDigits { _number = -1*(firstDigit._number * secondDigit._number) };
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            else
            {
                ComplexityDigits digit = (ComplexityDigits)obj;
                return (_number==digit._number);
            }
        }

        public override int GetHashCode()
        {
            return _number.GetHashCode();
        }
    }
}
