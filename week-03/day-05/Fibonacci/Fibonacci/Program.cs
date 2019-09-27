using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {

        static Dictionary<int, int> fibonacciCache = new Dictionary<int, int>();


        public static int CountFibonacci(int n)
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
            }
        }


        static void Main(string[] args)
        {
            int number = new int();

            Console.Write("Give me a int number to count Fibonacci: ");
            number = Convert.ToInt32(Console.ReadLine());

            CountFibonacciCache(number);
            Console.WriteLine(CountFibonacci(number));
            Console.WriteLine();

            foreach (var item in fibonacciCache)
            {
                Console.WriteLine("Cache: " + item.Key + " " + item.Value);
                
            }
        }
    }
}
