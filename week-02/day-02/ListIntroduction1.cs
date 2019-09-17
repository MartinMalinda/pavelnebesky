using System;
using System.Collections.Generic;

namespace ListIntroduction1
{
    public class ListIntroduction1
    {
        
        public static void Main(string[] args)

        //Create an empty list which will contain names(strings)
        //Print out the number of elements in the list
        //Add William to the list
        //Print out whether the list is empty or not
        //Add John to the list
        //Add Amanda to the list
        //Print out the number of elements in the list
        //Print out the 3rd element
        //Iterate through the list and print out each name
        //William
        //John
        //Amanda
        //Iterate through the list and print
        //1.William
        //2.John
        //3.Amanda
        //Remove the 2nd element
        //Iterate through the list in a reversed order and print out each name
        //Amanda
        //William
        //Remove all elements
        {
            List <string> names = new List <string>();

            Console.WriteLine(names.Count);

            names.Add("William");

            Console.WriteLine("Is the list empty? " + (names.Count == 0));

            names.Add("John");

            names.Add("Amanda");

            Console.WriteLine(names.Count);

            Console.WriteLine(names[2]);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + names[i]);
            }

            names.RemoveAt(1);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[names.Count-1-i]);
            }

            names.Clear();



        }
    }
}