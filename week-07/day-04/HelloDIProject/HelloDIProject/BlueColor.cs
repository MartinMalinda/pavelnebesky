using System;
namespace HelloDIProject
{
    public class BlueColor : IColor
    {
        public BlueColor()
        {
        }

        public void PrintColor(Printer printer)
        {
            printer.Log("It is BLUE color.");
        }
    }
}
