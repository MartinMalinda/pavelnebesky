using System;
using System.Collections.Generic;

namespace MapIntroduction1
{
    public class MapIntroduction1
    {
        
        public static void Main(string[] args)

        {
            //We are going to play with maps.Feel free to use the built-in methods where possible.

            //Create an empty map where the keys are integers and the values are characters

            //Print out whether the map is empty or not

            //Add the following key - value pairs to the map

            //Key Value
            //97  a
            //98  b
            //99  c
            //65  A
            //66  B
            //67  C
            //Print all the keys

            //Print all the values

            //Add value D with the key 68

            //Print how many key-value pairs are in the map

            //Print the value that is associated with key 99

            //Remove the key - value pair where with key 97

            //Print whether there is an associated value with key 100 or not

            //Remove all the key-value pairs

            Dictionary<int, char> map = new Dictionary<int, char>();

            Console.WriteLine("Is map empty? " + (map.Count==0));

            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            foreach (var item in map)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in map)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(map.Count);

            Console.WriteLine(map[99]);

            map.Remove(97);

            char tempChar = new char();

            Console.WriteLine("Is there asociated value with key 100? " + map.TryGetValue(100, out tempChar));

            map.Clear();

        }
    }
}