using System;
namespace Music
{

    //Violin(4 strings, "Screech")

    public class Violin : StringedInstrument
    {

        public string voice = "screech";

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

        public Violin()
        {
            numberOfStrings = 4;
        }

        public Violin(int inputNumberOfStrings)
        {
            numberOfStrings = inputNumberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine("Violin, a " + NumberOfStrings + " - stringed instrument that " + Voice + "es");
        }

    }
}
