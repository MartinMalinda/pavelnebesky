using System;
using Xunit;
using MostCommonCharacters;
using System.Collections.Generic;

namespace CountLettersTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            Dictionary<char, int> occurrencesTest = new Dictionary<char, int>();
            string testString = "this is test string";
            occurrencesTest.Add('t', 4);
            occurrencesTest.Add('h', 1);
            occurrencesTest.Add('i', 3);
            occurrencesTest.Add('s', 4);
            occurrencesTest.Add('e', 1);
            occurrencesTest.Add(' ', 3);
            occurrencesTest.Add('r', 1);
            occurrencesTest.Add('n', 1);
            occurrencesTest.Add('g', 1);

            Assert.Equal(occurrencesTest, Program.toDictionary(testString));
        }
    }
}
