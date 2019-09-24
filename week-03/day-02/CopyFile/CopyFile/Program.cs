using System;
using System.IO;

namespace CopyFile
{
    class Program
    {

        // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
        // It should take the filenames as parameters
        // It should return a boolean that shows if the copy was successful

        public static bool Copy (string inputPath, string outputPath)
        {
            bool success = false;
            try
            {
                File.WriteAllText(outputPath, File.ReadAllText(inputPath));
                success = true;
            }
            catch
            {

            }
            return success;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Copy(@"./input.txt", @"./output.txt"));
        }
    }
}
