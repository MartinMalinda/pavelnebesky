using System;
namespace PetrolStation
{

    //Petrol Station
    //Create Station and Car classes
    //Station
    //GasAmount
    //Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount
    //Car
    //GasAmount
    //Capacity
    //create constructor for Car where:
    //initialize gasAmount -> 0
    //initialize capacity -> 100

    public class Car
    {
        public int GasAmount { get; set; } = 0;
        public int Capacity { get; private set; } = 100;

        public Car()
        { 

        }
    }
}
