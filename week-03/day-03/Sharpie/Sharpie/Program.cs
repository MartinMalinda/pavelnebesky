﻿using System;

namespace Sharpie
{
    class Program
    {

        //Create Sharpie class
        //We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
        //When creating one, we need to specify the Color and the Width
        //Every sharpie is created with a default 100 as InkAmount
        //We can Use() the sharpie objects
        //which decreases inkAmount

        static void Main(string[] args)
        {
            var mySharpie = new Sharpie("Blue", 10);

            mySharpie.Use();

            Console.WriteLine(mySharpie.Inkamount);
        }
    }
}
