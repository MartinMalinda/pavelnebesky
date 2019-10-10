using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            int numberOfNumbers = new int();

            Console.WriteLine("Please give me number of numbers: ");
            numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.WriteLine("Please give me " + (i+1) + ". number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int sumOfNumbers = 0;

            foreach (var item in numbers)
            {
                sumOfNumbers += item;
            }

            double averageOfNumbers = 0;

            averageOfNumbers = Convert.ToDouble(sumOfNumbers) / Convert.ToDouble(numbers.Count);

            Console.WriteLine();
            Console.WriteLine("Sum: " + sumOfNumbers + ", Average: " + averageOfNumbers);

        }
    }
}
