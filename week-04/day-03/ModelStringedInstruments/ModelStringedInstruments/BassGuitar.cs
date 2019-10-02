using System;
namespace Music
{

    //Bass Guitar(4 strings, "Duum-duum-duum")

    public class BassGuitar : StringedInstrument
    {

        public string voice = "Duum-duum-duum";

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

        public BassGuitar()
        {
            numberOfStrings = 4;
        }

        public BassGuitar(int inputNumberOfStrings)
        {
            numberOfStrings = inputNumberOfStrings;
        }
    }
}
