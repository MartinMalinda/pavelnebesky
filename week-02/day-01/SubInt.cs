using System;

namespace GreenFox
{
    class Program
    {
        public static int [] SubInt (int a, int [] inputArray)
            {
            int[] outputArray = new int[100];
            string arrayNumber;
            string givenNumber = Convert.ToString(a);
            int outputArrayPosition = 0;
            int dataLenght = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                arrayNumber = Convert.ToString(inputArray[i]);
                if (arrayNumber.IndexOf(givenNumber, StringComparison.Ordinal) != -1)
                {
                    outputArray[outputArrayPosition] = i;
                    outputArrayPosition++;
                    dataLenght = outputArrayPosition;
                }
            }
      

            int[] outputArrayWithoutZeroes = new int[dataLenght];
                for (int i = 0; i < dataLenght; i++)
                {
                    outputArrayWithoutZeroes[i] = outputArray[i];
                }
                
            return outputArrayWithoutZeroes; 
            }
            
        

        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array

            //  Example:
            //  Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //  Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            int[] arrayToPrint = SubInt(1, new int[] { 1, 11, 34, 52, 61 });
            Console.Write("[");
            foreach (var member in arrayToPrint)
            {
                Console.Write(member + " ");
            }
            Console.WriteLine("]");

        }
    }
}