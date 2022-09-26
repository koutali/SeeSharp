using Xunit;

namespace LongestSubstringTests
{
    public class LongestSubstringTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "abcabcbb";
            const int expected = 3;
            var returned = LongestSubstring.LongestSubstring.LengthOfLongestSubstring(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const string s = "bbbbb";
            const int expected = 1;
            var returned = LongestSubstring.LongestSubstring.LengthOfLongestSubstring(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            const string s = "pwwkew";
            const int expected = 3;
            var returned = LongestSubstring.LongestSubstring.LengthOfLongestSubstring(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            const int expected = 0;
            var returned = LongestSubstring.LongestSubstring.LengthOfLongestSubstring(string.Empty);
            Assert.Equal(expected, returned);
        }
    }
}
