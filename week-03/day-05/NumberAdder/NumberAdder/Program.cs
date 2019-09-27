using System;

namespace NumberAdder
{

    //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

    class Program
    {

        public static int AddNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + AddNumbers(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            Console.WriteLine(AddNumbers(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
