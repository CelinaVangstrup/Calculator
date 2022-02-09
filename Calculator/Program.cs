using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator sc = new SimpleCalculator();
            sc.Add(5, 3);
            Console.WriteLine(sc.Add(5, 3));
        }
    }
}
