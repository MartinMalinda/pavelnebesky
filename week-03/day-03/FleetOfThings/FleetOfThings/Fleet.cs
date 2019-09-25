using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing, bool completed)
        {
            if (completed)
            {
                thing.Complete();
            }
            things.Add(thing);
        }

        public void Print()
        {
            int i = 0;
            foreach (var thing in things)
            {
                i++;
                Console.Write(i + ". [");
                if (thing.completed)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.WriteLine("] "+thing.name);
            }
        }
    }
}
