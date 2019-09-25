using System;

namespace Counter
{
    class Program
    {

//Create Counter class
//which has an integer property
//when creating it should have a default value 0 or we can specify it when creating
//we can Add(number) to this counter another whole number
//or we can Add() without parameters just increasing the counter's value by one
//and we can Get() the current value as string
//also we can Reset() the value to the initial value

        static void Main(string[] args)
        {

            var myNumber = new Counter();
            myNumber.Add(10);
            myNumber.Add();

            Console.WriteLine(myNumber.Number);
            string test = myNumber.Get();
            Console.WriteLine(test);
        }
    }
}
