using MinimumWindowSubstring;
using Xunit;

namespace MinimumWindowSubstringTests
{
    public class MinimumWindowTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "ADOBECODEBANC";
            const string t = "ABC";
            const string expected = "BANC";
            var minWindow = MinimumWindow.MinWindow(s, t);
            Assert.Equal(expected, minWindow);
        }

        [Fact]
        public void Test2()
        {
            const string s = "a";
            const string t = "a";
            const string expected = "a";
            var minWindow = MinimumWindow.MinWindow(s, t);
            Assert.Equal(expected, minWindow);
        }

        [Fact]
        public void Test3()
        {
            const string s = "a";
            const string t = "aa";
            var expected = string.Empty;
            var minWindow = MinimumWindow.MinWindow(s, t);
            Assert.Equal(expected, minWindow);
        }

        [Fact]
        public void Test4()
        {
            const string s = "aa";
            const string t = "aa";
            var expected = "aa";
            var minWindow = MinimumWindow.MinWindow(s, t);
            Assert.Equal(expected, minWindow);
        }

        [Fact]
        public void Test5()
        {
            const string s = "cabwefgewcwaefgcf";
            const string t = "cae";
            var expected = "cwae";
            var minWindow = MinimumWindow.MinWindow(s, t);
            Assert.Equal(expected, minWindow);
        }
    }
}