using System;

namespace Animal
{
    class Program
    {

        //Create an Animal class
        //Every animal has a hunger value, which is a whole number
        //Every animal has a thirst value, which is a whole number
        //when creating a new animal object these values are created with the default 50 value
        //Every animal can Eat() which decreases their hunger by one
        //Every animal can Drink() which decreases their thirst by one
        //Every animal can Play() which increases both by one

        static void Main(string[] args)
        {
            var pig = new Animal();

            pig.Eat();

            Console.WriteLine(pig.Hunger);
        }
    }
}
