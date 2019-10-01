using System;
namespace TheGardenApplication
{
    //The Tree
    //needs water if its current water amount is less then 10
    //when watering it the tree can only absorb the 40% of the water
    //eg. watering with 10 the tree's amount of water should only increase with 4

    public class Tree : Plant
    {

        private bool needsWatter;

        public bool NeedsWatter
        {
            get
            {
                if (WaterAmount < 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Tree(string inputColor) : base(inputColor, 0.4f)
        {

        }
    }
}
