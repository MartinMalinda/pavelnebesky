using System;
using System.Linq;

namespace Exercise5
{
    class Program
    {

        //Write a LINQ Expression to find the frequency of numbers in the following array:

        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

           
            n.GroupBy(n => n).ToList().ForEach(r => Console.WriteLine(r.Key + ": " + r.Count()));
            

        }
    }
}
