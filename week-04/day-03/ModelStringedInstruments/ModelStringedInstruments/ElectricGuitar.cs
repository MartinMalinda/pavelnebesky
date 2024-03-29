﻿using System;
namespace Music
{

    //Electric Guitar(6 strings, "Twang")

    public class ElectricGuitar : StringedInstrument
    {

        public string voice = "twang";

        public string Voice
        {
            get
            {
                return voice;
            }
        }

        public int NumberOfStrings
        {
            get
            {
                return numberOfStrings;
            }
        }

        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }

        public ElectricGuitar(int inputNumberOfStrings)
        {
            numberOfStrings = inputNumberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine("Electric Guitar, a " + NumberOfStrings + " - stringed instrument that " + Voice + "s");
        }

    }
}
