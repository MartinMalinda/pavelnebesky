using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        // Write a function that takes a filename as string,
        // then returns the number of lines the file contains.
        // It should return zero if it can't open the file, and
        // should not raise any error.

        public static int NumberOfLines (string path)
        {
            int numCount = 0;

            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    numCount++;
                }
            }

            catch (Exception)
            {
                
            }
            return numCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLines(@"../../../my-file.txt"));
        }
    }
}
