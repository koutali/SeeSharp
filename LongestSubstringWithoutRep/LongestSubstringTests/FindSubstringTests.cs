using LongestSubstringWithoutRep;
using Xunit;

namespace LongestSubstringTests
{
    public class FindSubstringTests
    {
        [Fact]
        public void FailedTest()
        {
            const string s = "dvdf";
            const int expected = 3;
            var returned = FindSubstring.LengthOfLongestSubstring(s);
            Assert.Equal(expected, returned);
        }
    }
}
