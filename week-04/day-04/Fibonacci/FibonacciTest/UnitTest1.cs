using System;
using Xunit;
using Fibonacci;

namespace FibonacciTest
{
    public class UnitTest1
    {

        //Write a function that computes a member of the fibonacci sequence by a given index
        //Create tests for multiple test cases.

        [Fact]
        public void Test1()
        {
            Double fibonacci1 = 1;
            Double fibonacci5 = 5;
            Double fibonacci10 = 55;

            Assert.Equal(fibonacci1, Program.Fibonacci(1));
            Assert.Equal(fibonacci5, Program.Fibonacci(5));
            Assert.Equal(fibonacci10, Program.Fibonacci(10));


        }
    }
}
