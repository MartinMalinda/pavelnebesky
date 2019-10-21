using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {

        //Write a LINQ Expression to get the average value of the odd numbers from the following array:

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result = n.Where(n => n % 2 == 1).Average();
			Console.WriteLine(result);

            Console.WriteLine();

            var resultQuery = (from item in n
                              where item % 2 == 1
                              select item).Average();

           
            Console.WriteLine(resultQuery);
            

        }
    }
}
