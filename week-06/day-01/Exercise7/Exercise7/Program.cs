using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {

        //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };


            cities.Where(n => (n[0] == 'A' && n[cities.Length-1] == 'I')).ToList().ForEach(r => Console.WriteLine(r));

            Console.WriteLine();

            var resultQuery = from item in cities
                              where (item[0] == 'A' && item[cities.Length - 1] == 'I')
                              select item;

            foreach (var item in resultQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
