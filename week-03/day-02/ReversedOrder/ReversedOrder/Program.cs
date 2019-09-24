using System;
using System.IO;

namespace ReversedOrder
{
    class Program
    {
        public static void ReverseOrder(string inputFile, string outputFile)
        {
            string[] lines = File.ReadAllLines(inputFile);
            for (int i = lines.Length - 1; i > -1; i--)
                {
                File.AppendAllText(outputFile, lines[i]+ "\n");
                }
        }

        static void Main(string[] args)
        {
            ReverseOrder("reversed-order.txt", "non-reversed-order.txt");
        }
    }
}
