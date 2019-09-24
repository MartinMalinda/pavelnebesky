using System;
using System.IO;

namespace ReversedLines
{
    class Program
    {

        public static void Decode(string inputFile, string outputFile)
        {
            string inputLine = "";
            string outputLine = "";
            using (StreamReader reader = new StreamReader(inputFile))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    for (int i = inputLine.Length-1; i > -1; i--)
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
            Decode("reversed-lines.txt", "non-reversed-lines.txt");
        }
    }
}
