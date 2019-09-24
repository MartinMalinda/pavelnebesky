using System;
using System.Collections.Generic;
using System.IO;

namespace Logs
{
    class Program
    {

        // Read all data from 'log.txt'.
        // Each line represents a log message from a web server
        // Write a function that returns an array with the unique IP adresses.
        // Write a function that returns the GET / POST request ratio.

        public static string[] GetIPArray (string inputFile)
        {
            List<string> IPList = new List<string>();
            string inputLine = new string("");
            string IPadress = new string("");

            using (StreamReader reader = new StreamReader(inputFile))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    IPadress = inputLine.Substring(27, 11);
                    if (!IPList.Contains(IPadress))
                    {
                        IPList.Add(IPadress);
                    }
                }
            }
            string[] IParray = new string[IPList.Count];
            for (int i = 0; i < IPList.Count; i++)
            {
                IParray[i] = IPList[i];
            }
            return IParray;
        }

        public static double GetPostRatio(string inputFile)
        {
            char getPost = new char();
            string inputLine = new string("");
            int numberOfGets = 0;
            int numberOfPosts = 0;
            using (StreamReader reader = new StreamReader(inputFile))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    getPost = inputLine[41];
                    if (getPost == 'G')
                    {
                        numberOfGets++;
                    }
                    else
                    {
                        numberOfPosts++;
                    }
                }
            }
            Console.WriteLine("GETs: " + numberOfGets);
            Console.WriteLine("POSTs: " + numberOfPosts);
            double GPRatio = (double)numberOfGets / numberOfPosts;
            return GPRatio;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of unique IPs: " + GetIPArray("log.txt").Length);
            Console.WriteLine("GET / POST ratio: " + GetPostRatio("log.txt"));
        }
    }
}
