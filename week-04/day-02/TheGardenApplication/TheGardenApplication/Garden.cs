using System;
using System.Collections.Generic;

namespace TheGardenApplication
{
    static class Garden
    {

        public static void PrintGarden(List<Flower> flowers, List<Tree> trees)
        {
            foreach (var item in flowers)
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

            foreach (var item in trees)
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


        public static void WatteringGarden(float amountOfWatter, List<Flower> flowers, List<Tree> trees)
        {
            Console.WriteLine("Wattering with " + amountOfWatter);
            int countOfPlantsNeedsWatter = 0;
            foreach (var item in flowers)
            {
                if (item.NeedsWatter)
                {
                    countOfPlantsNeedsWatter++;
                }
            }

            foreach (var item in trees)
            {
                if (item.NeedsWatter)
                {
                    countOfPlantsNeedsWatter++;
                }
            }

            for (int i = 0; i < flowers.Count; i++)
            {
                if (flowers[i].NeedsWatter)
                {
                    flowers[i].PlantWatering(amountOfWatter / countOfPlantsNeedsWatter);
                }

            }

            for (int i = 0; i < trees.Count; i++)
            {
                if (trees[i].NeedsWatter)
                {
                    trees[i].PlantWatering(amountOfWatter / countOfPlantsNeedsWatter);
                }

            }

        }

    }
}
