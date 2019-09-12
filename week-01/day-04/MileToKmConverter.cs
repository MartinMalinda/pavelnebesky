using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.WriteLine("What is the distance in miles?");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The distance in kilometers is: " + miles*1.609344);
        }
    }
}