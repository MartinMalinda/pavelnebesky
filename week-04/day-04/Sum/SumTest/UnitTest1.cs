using System;
using Xunit;
using SumNamespace;
using System.Collections.Generic;

namespace SumTest
{
    //Create an xUnit project
    //Add a Test class to your project
    //Add a new Test case in it
    //Instantiate your class (arrange, act, assert)
    //create a list of integers
    //use the Assert.Equal() to test the result of the created sum method
    //Run them
    //Create different tests where you test your method with:
    //an empyt list
    //a list that has one element in it
    //a list that has multiple elements in it
    //a null
    //Run them
    //Fix your code if needed

    public class UnitTest1
    {
        List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        [Fact]
        public void Test1()
        {
            Assert.Equal(28, SumClass.Sum(testList));
        }
   

        List<int> testList2 = new List<int>();
        List<int> testList3 = new List<int> { 7 };
        List<int> testList4 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        List<int> testList5 = null;
       

        [Fact]
        public void Test2()
        {
            Assert.Equal(0, SumClass.Sum(testList2));
            Assert.Equal(7, SumClass.Sum(testList3));
            Assert.Equal(28, SumClass.Sum(testList4));
            Assert.Equal(0, SumClass.Sum(testList5));
        }
    }

}
