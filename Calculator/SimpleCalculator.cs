using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class SimpleCalculator
    {
        public double Accumulate { get; private set; } = 0;
        
        public double Add(double a, double b)
        {
            var addResult = a + b;

            Accumulate = addResult;
            return addResult;
        }
        public double Subtract(double a, double b)
        {
            var subResult = a - b;

            Accumulate = subResult;
            return subResult;
        }

        public double Multiply(double a, double b)
        {
            var multiResult = a * b;

            Accumulate = multiResult;
            return multiResult;
        }

        public double Power(double x, double exp)
        {
            var powerResult = Math.Pow(x, exp);

            Accumulate = powerResult;
            return powerResult;
        }

        public double Divide(double dividend, double divisor)
        {
            
           if (divisor!=0)
           {
               var divideResult = dividend / divisor;
               Accumulate = divideResult;
               return divideResult;
           }
           else
           {
              throw new Exception("Du prøvede at dividere med nul");
           }
        }

        public void Clear()
        {
            Accumulate = 0;
        }
    }
}
