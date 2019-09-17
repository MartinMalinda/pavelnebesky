using System;
using System.Collections.Generic;

namespace ListIntroduction2
{
    public class ListIntroduction2
    {

        public static void Main(string[] args)

        {
            //Create a list('List A') which contains the following values
            //Apple, Avocado, Blueberries, Durian, Lychee
            //Create a new list('List B') with the values of List A
            //Print out whether List A contains Durian or not
            //Remove Durian from List B
            //Add Kiwifruit to List A after the 4th element
            //Compare the size of List A and List B
            //Get the index of Avocado from List A
            //Get the index of Durian from List B
            //Add Passion Fruit and Pomelo to List B in a single statement
            //Print out the 3rd element from List A

            List<string> listA = new List<string>{ "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> listB = new List<string>();

            for (int i = 0; i < listA.Count-1; i++)
            {
                listB.Add(listA[i]);
            }

            Console.WriteLine("Contains List A Durian? " + listA.Contains("Durian"));

            listB.Remove("Durian");

            listA.Insert(4, "Kiwifruit");

            Console.WriteLine("---------- List A");

            foreach (var item in listA)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------- List B");

            foreach (var item in listB)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("list A is longer than list B: " + (listA.Count > listB.Count));

            Console.WriteLine("Index of Avocado in List A is: " + listA.IndexOf("Avocado"));
            Console.WriteLine("Index of Durian in List B is: " + listA.IndexOf("Durian"));

            listB.AddRange(new string[] { "Passion Fruit", "Pomelo" });

            Console.WriteLine(listA[2]);
            
        }
    }
}
