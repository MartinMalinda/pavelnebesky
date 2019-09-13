using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Give me a number of triangle lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i < lines; i++)
                {
                for (int star=0; star<i; star++)
                    {
                    Console.Write("*");
                    }
                    Console.WriteLine("*");
            }

        }
    }
}