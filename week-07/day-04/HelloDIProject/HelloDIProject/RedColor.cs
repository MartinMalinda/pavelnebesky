using System;
namespace HelloDIProject
{
    public class RedColor : IColor
    {

       
        public RedColor()
        {

        }

        public void PrintColor(Printer printer)
        {
            printer.Log("It is RED color.");
        }
    }
}
