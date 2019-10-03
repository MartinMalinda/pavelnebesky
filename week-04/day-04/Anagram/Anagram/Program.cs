using System;
using System.Collections;

namespace Anagram
{
    public class Program
    {

		//Write a function, that takes two strings and returns a boolean value based on if the two strings are Anagramms or not.
		//Create a test for that.

		public static bool isAnagram(string inputString1, string inputString2)
		{
            char[] array1 = inputString1.ToCharArray();
            Array.Sort<char>(array1);
            string sortedString1 = new string(array1);

            char[] array2 = inputString2.ToCharArray();
            Array.Sort<char>(array2);
            string sortedString2 = new string(array2);

            Console.WriteLine(sortedString1);
            Console.WriteLine(sortedString2);


            if (sortedString1 == sortedString2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		static void Main(string[] args)
        {
          
        }
    }
}
