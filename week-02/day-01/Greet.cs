using System;

namespace Greet
{
    class Program
    {
        public static void Greet(string a)
        {
            Console.WriteLine("Greetings dear, "+a);
        }

        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`
            string al = "Green Fox";
            Greet(al);
        }
    }
}