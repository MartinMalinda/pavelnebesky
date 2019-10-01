using System;
namespace TheGardenApplication
{

    //The Flower
    //needs water if its current water amount is less then 5
    //when watering it the flower can only absorb the 75% of the water
    //eg.watering with 10 the flower's amount of water should only increase with 7.5
    //The Tree
    //needs water if its current water amount is less then 10
    //when watering it the tree can only absorb the 40% of the water
    //eg. watering with 10 the tree's amount of water should only increase with 4

    public class Plant
    {
        private string color;
        private float waterAmount;
        private float absorbance;

        public string Color
        {
            get
            {
                return color;
            }
        }
        public float WaterAmount
        {
            get
            {
                return waterAmount;
            }
        }
        public float Absorbance
        {
            get
            {
                return absorbance;
            }
        }

        public Plant(string inputColor, float inputAbsorbance)
        {
            color = inputColor;
            absorbance = inputAbsorbance;
            waterAmount = 0;
        }

        public void PlantWatering (float amountOfWatter)
        {
            waterAmount += (amountOfWatter * absorbance);
        }
    }
}
