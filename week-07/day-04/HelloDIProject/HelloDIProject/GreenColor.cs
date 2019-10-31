using System;
namespace HelloDIProject
{
    public class GreenColor : IColor
    {
        public GreenColor()
        {
        }

        public void PrintColor(Printer printer)
        {
            printer.Log("It is GREEN color.");
        }
    }
}
