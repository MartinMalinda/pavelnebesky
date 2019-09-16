using System;

namespace Sum
{
    class Program
    {
        public static int Sum (int a)
        {
            int sum = 0;
            for (int i = 0; i <=a ; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of numbers from zero to the given number is " + Sum(number)); 

        }
    }
}