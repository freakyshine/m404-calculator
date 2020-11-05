using System;
using System.Transactions;

namespace M404Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();

            Console.WriteLine("Please enter 2 numbers and enter them seperated by a line break");
            Console.WriteLine("Addition: "+calculator.Addition(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Please enter 2 numbers and enter them seperated by a line break"); 
            Console.WriteLine("Subtraction: " + calculator.Subtraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Please enter 2 numbers and enter them seperated by a line break");
            Console.WriteLine("Multiplication: " + calculator.Multiplication(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Please enter 2 numbers and enter them seperated by a line break");
            Console.WriteLine("Division: " + calculator.Division(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

        }
    }
}
