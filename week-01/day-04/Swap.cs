using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            Console.WriteLine("a= " + a + " b= " + b);
            (a, b) = (b, a);
            Console.WriteLine("a= " + a + " b= " + b);
        }
    }
}