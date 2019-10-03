using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            int[] array1 = { a, b, c };
            return array1.Max();
        }

        public double Median(List<int> pool)
        {
            if (pool.Count % 2 == 0)
            {
                return Convert.ToDouble((pool[(pool.Count / 2)-1] + pool[pool.Count / 2])) / 2;
            }
            else
            {
                return pool[((pool.Count + 1) / 2)-1];
            }
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Median(new List<int>() { 1, 2, 3, 4 }));
            //Console.WriteLine(Median(new List<int>() { 1, 2, 2, 4, 5 }));
        }
    }
}

// Check out the folder. There's a work file and a test file.

//  -  Run the tests, all 10 should be green (passing).
//  -  The implementations though are not quite good.
//  -  Create tests that'll fail, and will show how the implementations are wrong(You can assume that the implementation of join and split are good)
//  -  After creating the tests, fix the implementations
//  -  Check again, if you can create failing tests
//  -  Implement if needed