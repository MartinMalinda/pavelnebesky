using System;
using System.Collections.Generic;
using System.IO;

namespace MostCommonCharacters
{
    public class Program
    {
        
        //Write a function, that takes a string as an argument and returns a dictionary with all letters in the string as keys, and numbers as values that shows how many occurrences there are.
        //Create a test for that.

        public static Dictionary<char, int> toDictionary(string inputString)
        {
            Dictionary<char, int> occurrences = new Dictionary<char, int> ();
            
            foreach (var item in inputString)
            {
                if (occurrences.ContainsKey(item))
                {
                    occurrences[item]++;
                }
                else
                {
                    occurrences.Add(item, 1);
                }
            }

            return occurrences;
        }

        static void Main(string[] args)
        {
            Dictionary<char, int> occurrencesTest = new Dictionary<char, int>();
            occurrencesTest = toDictionary("this is test string");
            foreach (var item in occurrencesTest)
            {
                Console.WriteLine(item.Key + " : "+ item.Value);
            }

        }
    }
}
