using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 8;
            double b = 10;
            double c = 12;
            Console.WriteLine("side a is "+ a +", side b is "+ b +", side c is "+ c);
            Console.WriteLine("Surface area of the cuboid is: " + (2 * (( a * b) + (b * c) + (a * c))));
            Console.WriteLine("Volume of the cuboid is: " + (a * b * c));
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
        }
    }
}