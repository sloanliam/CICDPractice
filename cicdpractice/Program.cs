using System;

namespace cicdpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(2, 2));
            Console.WriteLine(calculator.Multiply(2, 2));
        }
    }
}
