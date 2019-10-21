using System;
using System.Linq;

namespace Exercise9
{
    class Program
    {

        //Write a LINQ Expression to convert a char array to a string.

        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'A', 'B', 'C', 'D', 'q', 'w', 'e' };


            string answerString = "";

            chars.ToList().ForEach(ch => answerString = answerString.Insert(answerString.Length,ch.ToString()));
            Console.WriteLine(answerString);

            Console.WriteLine();

            string answerStringQuery = "";

            var resultQuery = (from ch in chars
                                   
                               select answerStringQuery = answerStringQuery.Insert(answerStringQuery.Length, ch.ToString())).ToList();

                Console.WriteLine(answerStringQuery);
            
        }
    }
}
