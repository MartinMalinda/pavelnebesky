using System;

namespace Factorio
{
    class Program
    {
        public static int Factorio(int a)
        {
            int factorial = 1;
            for (int i = 0; i <= a; i++)
            {
                if (i == 0) { factorial = 1; }
                else { factorial *= i; }
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            Console.Write("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number's factorial is " + Factorio(number));
        }
    }
}