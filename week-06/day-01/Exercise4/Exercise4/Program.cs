using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var result = n.Where(n => n*n > 20);
            result.ToList().ForEach(r => Console.WriteLine(r));
        }
    }
}
