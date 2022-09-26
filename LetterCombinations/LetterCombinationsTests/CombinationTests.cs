using LetterCombinations;
using System.Collections.Generic;
using Xunit;

namespace LetterCombinationsTests
{
    public class CombinationTests
    {
        [Fact]
        public void Empty_input()
        {
            var combinations = new Combinations();
            var returned = combinations.LetterCombinations(string.Empty);
            Assert.Empty(returned);
        }

        [Fact]
        public void One_digit()
        {
            var combinations = new Combinations();
            var returned = combinations.LetterCombinations("2");
            var expected = new List<string>() {"a", "b","c"};
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digits()
        {
            var combinations = new Combinations();
            var returned = combinations.LetterCombinations("23");
            var expected = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            Assert.Equal(expected.Count,returned.Count);
            foreach (var s in expected)
            {
                Assert.True(returned.Contains(s));
            }
        }

        [Fact]
        public void Two_digits_different_size()
        {
            var combinations = new Combinations();
            var returned = combinations.LetterCombinations("89");
            var expected = new List<string>() { "tw", "ty", "tx", "tz", "uw", "uy", "ux", "uz", "vw", "vy", "vx", "vz" };

            Assert.Equal(expected.Count, returned.Count);
            foreach (var s in expected)
            {
                Assert.True(returned.Contains(s));
            }
        }

        [Fact]
        public void Three_digits()
        {
            var combinations = new Combinations();
            var returned = combinations.LetterCombinations("234");
            var expected = new List<string>() { "adg", "adh","adi", "aeg", "aeh", "aei", 
                                                "afg","afh","afi", "bdg","bdh","bdi",
                                                "beg","beh","bei", "bfg","bfh","bfi",
                                                "cdg","cdh","cdi", "ceg","ceh","cei",
                                                "cfg","cfh","cfi" };

            Assert.Equal(expected.Count, returned.Count);
            foreach (var s in expected)
            {
                Assert.True(returned.Contains(s));
            }
        }
    }
}
