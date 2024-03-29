﻿using System;
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

            Garden.Flowers = flowers;
            Garden.Trees = trees;

            Garden.Trees.Add(purple);

            Garden.PrintGarden();
            Garden.WatteringGarden(40);
            Garden.PrintGarden();
            Garden.WatteringGarden(70);
            Garden.PrintGarden();

        }

    }
}
