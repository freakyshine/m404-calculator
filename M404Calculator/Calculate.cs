namespace M404Calculator
{
    class Calculate
    {

        private int cachedResult;

        public int Addition (int number1, int number2)
        {
            cachedResult = number1 + number2;
            return cachedResult;
        }
        public int Subtraction (int number1, int number2)
        {
            cachedResult = number1 - number2;
            return cachedResult;
        }
        public int Multiplication (int number1, int number2)
        {
            cachedResult = number1 * number2;
            return cachedResult;
        }

        public int Division (int number1, int number2)
        {
            cachedResult = number1 / number2;
            return cachedResult;
        }
    }
}
