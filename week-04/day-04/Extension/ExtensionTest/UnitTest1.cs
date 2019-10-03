using Xunit;
using System.Collections.Generic;

namespace Extension
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Fact]
        public void TestAdd_2and3is5()
        {
            Assert.Equal(6, extension.Add(3, 3));
        }

        [Fact]
        public void TestAdd_1and4is5()
        {
            Assert.Equal(4, extension.Add(0, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(3, extension.MaxOfThree(1, 2, 3));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(2, 1, 5));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(2.5, extension.Median(new List<int>() { 1, 2, 3, 4 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(2, extension.Median(new List<int>() { 1, 2, 2, 4, 5 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('o'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}