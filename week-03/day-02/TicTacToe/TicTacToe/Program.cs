using System;
using System.IO;

namespace GreenFox
{
    class Program
    {

        public static string TicTacResult(string inputFile)
        {
            string allText = File.ReadAllText(inputFile);

            char[,] playground = new char[3, 3];
            int counter = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    playground[row, column] = allText[counter];
                    counter++;
                }
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine(playground[0, 0] + " "+ playground[0, 1] + " " + playground[0, 2]);
            Console.WriteLine(playground[1, 0] + " " + playground[1, 1] + " " + playground[1, 2]);
            Console.WriteLine(playground[2, 0] + " " + playground[2, 1] + " " + playground[2, 2]);

            return "nothing for now";
        }

        static void Main(string[] args)
        {
            // Write a function that takes a filename as a parameter
            // The file contains an ended Tic-Tac-Toe match
            // We have provided you some example files (draw.txt, win-x.txt, win-o.txt)
            // Return "X", "O" or "Draw" based on the input file



            Console.Write(TicTacResult("win-o.txt"));
            // Should print "O"

            Console.Write(TicTacResult("win-x.txt"));
            // Should print "X"

            Console.Write(TicTacResult("draw.txt"));
            // Should print "Draw"
        }
    }
}
