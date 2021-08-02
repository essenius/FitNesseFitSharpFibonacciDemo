using System;
using ExtendedMath;

[assembly: CLSCompliant(true)]
namespace ExtendedMathFixtures
{
    public class FibonacciFixture
    {
        public int InputValue { get; set; }

        public object Fibonacci()
        {
            try
            {
                return Functions.Fibonacci(InputValue);
            }
            catch (Exception e)
            {
                return e.GetType();
            }
        }
    }
}

