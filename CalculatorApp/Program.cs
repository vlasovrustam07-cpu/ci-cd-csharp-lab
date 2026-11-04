using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Калькулятор: 2 + 3 = " + calc.Add(2, 3));
        }
    }
}
