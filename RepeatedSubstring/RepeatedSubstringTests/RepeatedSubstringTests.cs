using Xunit;

namespace RepeatedSubstringTests
{
    public class RepeatedSubstringTests
    {
        [Fact]
        public void Test1()
        {
            const string input = "abab";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.True(returned);
        }

        [Fact]
        public void Test2()
        {
            const string input = "aba";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.False(returned);
        }

        [Fact]
        public void Test3()
        {
            const string input = "abcabcabcabc";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.True(returned);
        }

        [Fact]
        public void Test4()
        {
            const string input = "abcabc";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.True(returned);
        }

        [Fact]
        public void Test5()
        {
            const string input = "ababab";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.True(returned);
        }

        [Fact]
        public void Test6()
        {
            const string input = "abac";
            var returned = RepeatedSubstring.RepeatedSubstring.RepeatedSubstringPattern(input);
            Assert.False(returned);
        }
    }
}
