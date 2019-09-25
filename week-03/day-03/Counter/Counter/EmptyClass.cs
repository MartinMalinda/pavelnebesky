using System;
namespace Counter
{

    //Create Counter class
    //which has an integer property
    //when creating it should have a default value 0 or we can specify it when creating
    //we can Add(number) to this counter another whole number
    //or we can Add() without parameters just increasing the counter's value by one
    //and we can Get() the current value as string
    //also we can Reset() the value to the initial value

    public class Counter
    {
        public int Number { get; set; } = 0;

        public Counter()
        {
        }

        public Counter(int number)
        {
            Number = number;
        }

        public void Add(int toAdd)
        {
            Number += toAdd;
        }

        public void Add()
        {
            Number += 1;
        }

        public string Get()
        {
            return Convert.ToString(Number);
        }
        public void Reset()
        {
            Number = 0;
        }
    }
}
