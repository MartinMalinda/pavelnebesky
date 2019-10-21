using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {

        //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

        static void Main(string[] args)
        {
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result = n.Where(n => n > 0).Select(n => n*n);
			result.ToList().ForEach(r => Console.WriteLine(r));

            Console.WriteLine();

            var resultQuery = from item in n
                              where item > 0
                              select item*item;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }
       
        }
    }
}
