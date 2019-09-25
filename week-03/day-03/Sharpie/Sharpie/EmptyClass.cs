using System;
namespace Sharpie
{

    //Create Sharpie class
    //We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
    //When creating one, we need to specify the Color and the Width
    //Every sharpie is created with a default 100 as InkAmount
    //We can Use() the sharpie objects
    //which decreases inkAmount

    public class Sharpie
    {
        public string Color { get; set; }
        public float Width { get; set; }
        public float Inkamount { get; set; } = 100;


        public Sharpie(string color, float width)
        {
            Color = color;
            Width = width;
        }

        public void Use ()
        {
            Inkamount--;
        }

    }
}
