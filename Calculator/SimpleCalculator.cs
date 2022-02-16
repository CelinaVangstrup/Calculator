using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class SimpleCalculator
    {

        public double Add(double a, double b)
        {
            var addResult = a + b;

            return addResult;
        }
        public double Subtract(double a, double b)
        {
            var subResult = a - b;

            return subResult;
        }

        public double Multiply(double a, double b)
        {
            var multiResult = a * b;

            return multiResult;
        }

        public double Power(double x, double exp)
        {
            var powerResult = Math.Pow(x, exp);
            return powerResult;

        }

        public double Divide(double dividend, double divisor)
        {
           if (divisor!=0)
           {
            return dividend / divisor;
           }
           else
           {
              throw new Exception("Du prøvede at dividere med nul");
           }
        }
    }
}
