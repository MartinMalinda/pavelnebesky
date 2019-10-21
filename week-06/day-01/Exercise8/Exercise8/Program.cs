using System;
using System.Linq;

namespace Exercise8
{
    class Program
    {

        //Write a LINQ Expression to find the uppercase characters in a string.

        static void Main(string[] args)
        {
			string givenString = "This is the Pavels given string";


            givenString.ToCharArray().Where(g => g == Char.ToUpper(g) && g != ' ').ToList().ForEach(r => Console.WriteLine(r));

			Console.WriteLine();

            var resultQuery = from item in givenString
                              where item == Char.ToUpper(item) && item != ' '
                              select item;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
