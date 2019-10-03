using System;
using Xunit;
using Anagram;

namespace AnagramTest
{
    public class UnitTest1
    {

        string string1 = "bla";
        string string2 = "lab";

        [Fact]
        public void Test1()
        {
            Assert.True(Program.isAnagram(string1, string2));
        }
    }
}
