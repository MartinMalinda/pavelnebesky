using System;
using System.Collections.Generic;

namespace TheGardenApplication

//The Garden
//is able to hold unlimited amount of flowers or trees
//when watering it should only water those what needs water with equally divided amount amongst them
//eg.watering with 40 and 4 of them need water then each gets watered with 10

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flower> flowers = new List<Flower>();
            List<Tree> trees = new List<Tree>();

            var yellow = new Flower("yellow");
            var blue = new Flower("blue");
            var purple = new Tree("purple");
            var orange = new Tree("orange");

            flowers.Add(yellow);
            flowers.Add(blue);
            trees.Add(purple);
            trees.Add(orange);

            PrintGarden(flowers, trees);
            WatteringGarden(40, flowers, trees);
            PrintGarden(flowers, trees);
            WatteringGarden(70, flowers, trees);
            PrintGarden(flowers, trees);

        }

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
                if  (item.NeedsWatter)
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
