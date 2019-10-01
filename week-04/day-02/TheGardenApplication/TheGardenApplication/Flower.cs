using System;
namespace TheGardenApplication
{
    //The Flower
    //needs water if its current water amount is less then 5
    //when watering it the flower can only absorb the 75% of the water
    //eg.watering with 10 the flower's amount of water should only increase with 7.5

    public class Flower : Plant
    {

        private bool needsWatter;

        public bool NeedsWatter
        {
            get
            {
                if (WaterAmount < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Flower(string inputColor) : base (inputColor, 0.75f)
        {
            
        }
    }
}
