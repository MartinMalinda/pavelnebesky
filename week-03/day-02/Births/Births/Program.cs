using System;
using System.Collections.Generic;
using System.IO;

namespace Births
{
    class Program
    {

        // Create a function that
        // - takes the name of a CSV file as a parameter,
        //   - every row is in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
        // - returns the year when the most births happened.
        //   - if there were multiple years with the same number of births then return any one of them

        // You can find such a CSV file in this directory named births.csv
        // If you pass "births.csv" to your function, then the result should be either 2006, or 2016.

        static void Main(string[] args)
        {

            Dictionary<int, int> years = new Dictionary<int, int>();

            string[] lines = File.ReadAllLines("births.csv");
            foreach (string line in lines)
            {
                string[] col = line.Split(';');
                int year = Convert.ToInt32(col[1].Substring(0, 4));
                if (years.ContainsKey(year))
                {
                    years[year]++;
                }
                else
                {
                    years.Add(year, 1);
                }
          
            }

            int maxYear=0;
            int maxBirths=0;

            foreach (var item in years)
            {
                if (item.Value > maxBirths)
                {
                    maxBirths = item.Value;
                    maxYear = item.Key;
                }

                
            }

            Console.WriteLine(maxYear + " " + maxBirths);


        }
    }
}
