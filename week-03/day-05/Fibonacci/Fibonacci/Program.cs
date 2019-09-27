using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {

        static Dictionary<int, double> fibonacciCache = new Dictionary<int, double>();


        public static double CountFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else if (fibonacciCache.ContainsKey(n-1) && (fibonacciCache.ContainsKey(n - 2)))
            {
                return fibonacciCache[n-1] + fibonacciCache[n - 2];
            }
            else if (fibonacciCache.ContainsKey(n - 2))
            {
                return CountFibonacci(n - 1) + fibonacciCache[n - 2];
            }
            else
            {
                return CountFibonacci(n - 1) + CountFibonacci(n - 2);
            }
        }

        public static void CountFibonacciCache(int n)
        {

            for (int i = 0; i < n; i++)
            {
                fibonacciCache.Add(i, CountFibonacci(i));
                Console.WriteLine("Cache: " + i + " " + fibonacciCache[i]);
            }
        }


        static void Main(string[] args)
        {
            int number = new int();

            Console.Write("Give me a int number to count Fibonacci: ");
            number = Convert.ToInt32(Console.ReadLine());

            CountFibonacciCache(number);
            Console.WriteLine();
            Console.WriteLine("Fibonacci for " + number + " is: " + CountFibonacci(number));
            Console.WriteLine();

        }
    }
}
