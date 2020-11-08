using System;

namespace M404Calculator
{
    class Calculate
    {

        private int cachedResult; // this is the result of the last calculation
        private int number1;
        private int number2;
        private string userIn; // This variables used for the number input and stores an temporary value as string - it will be parsed to an integer
        public int Addition ()
        {
            DefineNumbers(" + "); 

            cachedResult = number1 + number2;
            return cachedResult;
        }
        public int Subtraction ()
        {
            DefineNumbers(" - ");

            cachedResult = number1 - number2;
            return cachedResult;
        }
        public int Multiplication ()
        {
            DefineNumbers(" * ");

            cachedResult = number1 * number2;
            return cachedResult;
        }

        public int Division ()
        {
            DefineNumbers(" / ");

            cachedResult = number1 / number2;
            return cachedResult;
        }

        /*
         This function defines the variables number1 and number 2 and uses the given strings for the command prompts
        */
        private void DefineNumbers(string calcSign)
        {
            do // While the userinput cannot be parsed it continuosly asks for an input
            {
                Console.WriteLine("Please enter an integer:");
                userIn = Console.ReadLine();
            } while (!int.TryParse(userIn, out number1));

            do // While the userinput cannot be parsed it continuosly asks for an input
            {
                Console.Clear();
                Console.Write(number1 + calcSign);
                userIn = Console.ReadLine();
            } while (!int.TryParse(userIn, out number2));
        }

        public int GetResult ()
        {
            Console.Clear();
            Console.Write("The result is: ");
            return cachedResult;
        }
    }
}
