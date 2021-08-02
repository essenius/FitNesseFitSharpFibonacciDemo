using System;

namespace ExtendedMath
{
    public static class Functions
    {
        public static int Fibonacci(int factor)
        {
            if (factor < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(factor), "Input should be 0 or positive");
            }

            if (factor < 2) { return factor; }

            var previousNumber = 1;
            var currentNumber = 1;
            for (var i = 2; i < factor; i++)
            {
                // throw overflow exception if needed
                var nextNumber = checked(previousNumber + currentNumber);
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }
            return currentNumber;
        }
    }
}

