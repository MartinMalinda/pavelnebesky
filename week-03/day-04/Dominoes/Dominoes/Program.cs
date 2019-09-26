using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

          
            WriteDominos(dominoes);

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;

        }

        public static void WriteDomino (Domino domino)
        {
            int[] values = new int[2];
            values = domino.GetValues();

            Console.Write("["+ values[0] + ", " + values[1] + "]");
        }

        public static void WriteDominos (List<Domino> dominos)
        {
            WriteDomino(dominos[0]);
            int k = 0;
            int currentDomino = 0;
            int[] dominoValues = new int[2];
            int[] nextDominoValues = new int[2];

            for (int dominoNumber = 0; dominoNumber < dominos.Count-2; dominoNumber++)
            {
                dominoValues = dominos[currentDomino].GetValues();
                nextDominoValues = dominos[currentDomino + 1].GetValues();

                while (dominoValues[1] != nextDominoValues[0])
                {
     
                    nextDominoValues = dominos[k].GetValues();
                    k++;
                }

                WriteDomino(dominos[k-1]);
                currentDomino = k-1;
                k = 0;
            }

            
        }  
    }
}
