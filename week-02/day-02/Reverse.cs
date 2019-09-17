using System;

namespace Reverse
{
    public class Reverse
    {
        public static string ReverseIt(string input)
        {
            string reversedInput = new string(""); 
            for (int i = 0; i<input.Length; i++)
            {
                reversedInput += input[input.Length - 1 - i];
            }
            return reversedInput;
        }

        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!


            Console.WriteLine(ReverseIt(reversed));
        }
    }
}
