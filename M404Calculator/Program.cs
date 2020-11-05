using System;

namespace M404Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();
            Console.WriteLine(calculator.Addition(1, 2));
        }
    }
}
