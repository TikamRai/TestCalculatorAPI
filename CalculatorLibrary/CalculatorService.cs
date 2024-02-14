using System;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        public decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            decimal difference = num1 - num2;
            return difference;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            decimal product = num1 * num2;
            return product;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            decimal quotient = num1 / num2;
            return quotient;
        }

        public decimal Modulo(decimal num1, decimal num2)
        {
            decimal remainder = num1 % num2;
            return remainder;
        }
    }
}