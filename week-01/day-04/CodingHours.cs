using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine("Average Green Fox attendee spent with coding " + 6 * 17 * 5 + " hours.");
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("Percentage of coding hours is " + ((6 * 5) / 52.0) * 100 +"%");
        }
    }
}