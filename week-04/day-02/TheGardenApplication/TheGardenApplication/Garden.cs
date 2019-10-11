using System;
using System.Collections.Generic;

namespace TheGardenApplication
{



    static class Garden
    {

        //public static List<Flower> flowers = new List<Flower>();

        public static List<Flower> Flowers {get; set; }
        public static List<Tree> Trees { get; set;}


        //public static Add()


        public static void PrintGarden()
        {
            foreach (var item in Flowers)
            {
                Console.Write("The " + item.Color + " Flower ");
                if (item.NeedsWatter)
                {
                    Console.Write("needs ");
                }
                else
                {
                    Console.Write("doesnt need ");
                }
                Console.WriteLine("water.");
            }

            foreach (var item in Trees)
            {
                Console.Write("The " + item.Color + " Tree ");
                if (item.NeedsWatter)
                {
                    Console.Write("needs ");
                }
                else
                {
                    Console.Write("doesnt need ");
                }
                Console.WriteLine("water.");
            }
            Console.WriteLine();
        }


        public static void WatteringGarden(float amountOfWatter)
        {
            Console.WriteLine("Wattering with " + amountOfWatter);
            int countOfPlantsNeedsWatter = 0;
            foreach (var item in Flowers)
            {
                if (item.NeedsWatter)
                {
                    countOfPlantsNeedsWatter++;
                }
            }

            foreach (var item in Trees)
            {
                if (item.NeedsWatter)
                {
                    countOfPlantsNeedsWatter++;
                }
            }

            for (int i = 0; i < Flowers.Count; i++)
            {
                if (Flowers[i].NeedsWatter)
                {
                    Flowers[i].PlantWatering(amountOfWatter / countOfPlantsNeedsWatter);
                }

            }

            for (int i = 0; i < Trees.Count; i++)
            {
                if (Trees[i].NeedsWatter)
                {
                    Trees[i].PlantWatering(amountOfWatter / countOfPlantsNeedsWatter);
                }

            }

        }

    }
}
