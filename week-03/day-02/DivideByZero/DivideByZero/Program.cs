using System;

namespace Example
{
    class Program
    {
        // Create a function that takes a number
        // divides ten with it,
        // and prints the result.
        // It should print "fail" if the parameter is 0

        public static void TenDividedBy(int number)
        {
            try  // Prevents the program breaking when attempting dividing by zero
            {
                // If the input value for divisor was 0 the program breaks
                int result = 10 / number;
                // The program doesn't reach this line if the input was 0
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                // This line only runs if the input was 0
                Console.WriteLine("fail");
            }
        }

        public static void Main(string[] args)
        {
            TenDividedBy(0);
            TenDividedBy(5);
        }
    }
}
