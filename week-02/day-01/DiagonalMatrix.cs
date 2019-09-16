using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                matrix[i, i] = 1;
            }

            for (int rowNumber = 0; rowNumber < 4; rowNumber++)
            {
                for (int characterPostion = 0; characterPostion < 4; characterPostion++)
                {
                    Console.Write(matrix[rowNumber,characterPostion] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}