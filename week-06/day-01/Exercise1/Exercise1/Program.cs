using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {

        // Write a LINQ Expression to get the even numbers from the following array:

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result = n.Where(n => n % 2 == 0);
            result.ToList().ForEach(r => Console.WriteLine(r));

            Console.WriteLine();

            var resultQuery = from item in n
                              where item % 2 == 0
                              select item;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }

        }
    }
}
