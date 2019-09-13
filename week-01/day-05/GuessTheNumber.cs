using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 65;
            int guess;

            Console.WriteLine("I have a stored integer number in my memory.");
           
            do
            {
                Console.WriteLine("Try a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < secretNumber)
                    {
                    Console.WriteLine("The stored number is higher");
                    }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("The stored number is lower");
                    }
                else
                    {
                    Console.WriteLine("You found the number " + guess);
                    }  
            } while (secretNumber != guess);

            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
        }
    }
}