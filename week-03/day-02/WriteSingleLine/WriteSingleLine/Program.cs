using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        // Write a function that is able to manipulate a file
        // By writing your name into it as a single line
        // The file should be named "my-file.txt"
        // In case the program is unable to write the file,
        // It should print the following error message: "Unable to write file: my-file.txt"

        public static void WriteNameToFile()
        {
            try
            {
                File.WriteAllText("./my-file.txt", "Pavel Nebesky");
            }

            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }

        static void Main(string[] args)
        {
            WriteNameToFile();
        }
    }
}
