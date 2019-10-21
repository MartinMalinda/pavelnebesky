using System;
using System.Linq;

namespace Exercise6
{

    //Write a LINQ Expression to find the frequency of characters in a given string.

    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "this is the given string";


            givenString.ToCharArray().GroupBy(n => n).ToList().ForEach(r => Console.WriteLine(r.Key + ": " + r.Count()));

            Console.WriteLine();

            var resultQuery = from item in givenString
                              group item by item;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item.Key + ": " + item.Count());
            }
        }
    }
}
