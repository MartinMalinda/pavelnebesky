using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> TreesData = new List<List<string>>()
            { new List<string> { "oak", "Green", "10", "male"},
              new List<string> { "peach tree", "Green", "20", "male"},
              new List<string> { "cherry tree", "Green", "30", "male"},
              new List<string> { "nut tree", "Green", "40", "male"},
              new List<string> { "kiwi tree", "Green", "50", "male"}
            };

            Console.WriteLine(TreesData[1][2]);
        }
    }
}
