using System;

namespace PetrolStation
{
    class Program
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

        static void Main(string[] args)
        {

            Car trabant = new Car();
            Station shell = new Station();

            shell.Refill(trabant);

            Console.WriteLine(trabant.GasAmount);
            Console.WriteLine(shell.GasAmount);
        }
    }
}
