using System;
using System.IO;
using System.Linq;

namespace Doubled
{
    class Program
    {

        // Create a method that decrypts the duplicated-chars.txt

        public static void Decode(string inputFile, string outputFile)
        {
            string inputLine = "";
            string outputLine = "";
            using (StreamReader reader = new StreamReader(inputFile))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < inputLine.Length; i = i + 2)
                    {
                        outputLine += inputLine[i];
                    }
                    outputLine += "\n";
                    File.AppendAllText(outputFile, outputLine);
                    outputLine = "";
                }
            }
        }

        static void Main(string[] args)
        {
            Decode("duplicated-chars.txt", "non-duplicated-chars.txt");
        }
    }
}
