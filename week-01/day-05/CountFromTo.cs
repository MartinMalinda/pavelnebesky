
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please give me a first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me a second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (secondNumber <= firstNumber)
                {
                Console.WriteLine("The second number should be bigger");
                }
            else
                {
                int subtract = secondNumber - firstNumber;
                for (int i= 0; i < subtract; i++)
                    {
                    Console.WriteLine((firstNumber + i));
                    }
                }


        }
    }
}