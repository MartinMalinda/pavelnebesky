using System;

namespace Power
{
    class Program
    {

        //Given base and n that are both 1 or more, compute recursively(no loops)
        //the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

        public static int CountPower(int n, int power)
        {
            if (power == 1)
            {
                return n;
            }
            else
            {
                return n * CountPower(n, power-1);
            }
        }

        static void Main(string[] args)
        {
            int baseNumber = new int();
            int powerNumber = new int();

            Console.WriteLine("Give me a base number: ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Give me a power number: ");
            powerNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CountPower(baseNumber, powerNumber));
        }
    }
}
