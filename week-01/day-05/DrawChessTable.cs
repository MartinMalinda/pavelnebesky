using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int rowNumber = 0; rowNumber < 8; rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < 8; columnNumber++)
                {

                    if (((rowNumber % 2 == 0) && (columnNumber % 2 == 0)) || ((rowNumber % 2 != 0) && (columnNumber % 2 != 0)))
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write(Environment.NewLine);
                                    
            }
        }
    }
}