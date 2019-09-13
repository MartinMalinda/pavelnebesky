using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("Please give me a number:");
            double number = Convert.ToDouble(Console.ReadLine());
            if ((number % 2) == 0)
                {
                Console.WriteLine("This is even number!");
                }
                else
                {
                Console.WriteLine("This is odd number!");
                }
        }
    }
}