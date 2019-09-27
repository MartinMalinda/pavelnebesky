using System;

namespace SumDigits
{
    class Program
    {


        //Given a non-negative integer n, return the sum of its digits recursively(without loops).
        //Hint
        //Mod(%) by 10 yields the rightmost digit(e.g. 126 % 10 is 6)

        //Java, C++, C#, Python
        //Divide(/) by 10 removes the rightmost digit(e.g. 126 / 10 is 12).

        public static int SumOfDigits(int n)
        { 
            if (n/10 == 0)
            {
                return n;
            }
            else
            {
                return n%10 + SumOfDigits(n/10);
            }
        }


        static void Main(string[] args)
        {
            int n = new int();
            Console.WriteLine("Give me a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of digits is: " + SumOfDigits(n));
        }
    }
}
