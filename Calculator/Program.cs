using System;

namespace Calculator
{
   class Program
   {
      static void Main(string[] args)
      {
         SimpleCalculator Calculator = new SimpleCalculator();

         Console.WriteLine("Velkommen til kalkulatoren.");
         Console.WriteLine("Indtast det første tal du vil regne med:");
         double number1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Indtast det andede tal du vil regne med:");
         var number2 = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Vælg hvilken operation du vil udføre");
         Console.WriteLine("Tryk [A] for at plusse");
         Console.WriteLine("Tryk [S] for at minusse");
         Console.WriteLine("Tryk [M] for at gange");
         Console.WriteLine("Tryk [D] for at dividere");


         while (true)
         {
            if (Console.KeyAvailable)
            {
               var key = Console.ReadKey(true);
               switch (key.KeyChar)
               {
                  case 'A':
                  case 'a':
                     Console.WriteLine(Calculator.Add(number1, number2));
                     break;
                  case 's':
                  case 'S':
                     Console.WriteLine(Calculator.Subtract(number1, number2));
                     break;
                  case 'm':
                  case 'M':
                     Console.WriteLine(Calculator.Multiply(number1, number2));
                     break;
                  case 'd':
                  case 'D':
                     Console.WriteLine(Calculator.Divide(number1, number2));
                     break;
               }
            }
         }
      }
   }
}
