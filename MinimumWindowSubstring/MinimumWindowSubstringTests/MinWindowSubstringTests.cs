using Xunit;

namespace MinimumWindowSubstringTests
{
    public class MinWindowSubstringTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "ADOBECODEBANC";
            const string t = "ABC";
            const string expected = "BANC";

            var returned = MinimumWindowSubstring.MinimumWindowSubstring.MinWindow(s, t);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const string s = "a";
            const string t = "a";
            const string expected = "a";

            var returned = MinimumWindowSubstring.MinimumWindowSubstring.MinWindow(s, t);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            const string s = "ADOBECODEBANC";
            const string t = "ABY";
            const string expected = "";

            var returned = MinimumWindowSubstring.MinimumWindowSubstring.MinWindow(s, t);
            Assert.Equal(expected, returned);
        }
    }
}
