using System;
using System.Globalization;
using System.Transactions;

namespace M404Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Calculate calculator = new Calculate();
            do {
                Console.WriteLine("Please enter a command \n" +
                "Enter [1] for Addition, [2] for Subtraction, [3] for Multiplication, [4] for Division, [99] to exit");
                input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("You've chosen 1 for addition");
                        calculator.Addition();
                        Console.WriteLine(calculator.GetResult());
                        break;
                    case "2":
                        Console.WriteLine("You've chosen 2 for subtraction");
                        calculator.Subtraction();
                        Console.WriteLine(calculator.GetResult());
                        break;
                    case "3":
                        Console.WriteLine("You've chosen 3 for multiplication");
                        calculator.Multiplication();
                        Console.WriteLine(calculator.GetResult());
                        break;
                    case "4":
                        Console.WriteLine("You've chosen 4 for division");
                        calculator.Division();
                        Console.WriteLine(calculator.GetResult());
                        break;
                }
                if (input != "99" || input != "") // this enables the user to see the result instead of just going to the menu back again
                {
                    Console.WriteLine("Please enter any key to continue.");
                    Console.ReadKey();
                }
                Console.Clear();
            } while (input != "99");
        }
    }
}
