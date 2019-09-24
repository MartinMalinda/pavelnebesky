using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            //string currentPath = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentPath);

            string path = @"../../../my-file.txt";
            try
            {
                string [] lines = File.ReadAllLines(path);
                // Prints the first line of the file
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}
