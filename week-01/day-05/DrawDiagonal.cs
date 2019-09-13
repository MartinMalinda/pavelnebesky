using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Give me a number of lines: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            bool write = true;

            for (int line = 0; line < lines; line++)
            {

                for (int character = 0; character < lines; character++)
                    {
                    write = ((line == 0) || (line == (lines - 1)) || (character == 0) || (character == (lines-1)) || (character == line));
                    if (write==true)
                        {
                        Console.Write("%");
                        }
                    else
                        {
                        Console.Write(" ");
                        }
                    }
                Console.Write("\n");
            }


            

        }
    }
}