using ValidParanthesesTests;
using Xunit;

namespace ValidParanthesesTest
{
    public class ValidParanthesesTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "lee(t(c)o)de)";
            const string expected = "lee(t(c)o)de";

            var returned = ValidParantheses.MinRemoveToMakeValid(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const string s = "a)b(c)d";
            const string expected = "ab(c)d";

            var returned = ValidParantheses.MinRemoveToMakeValid(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            const string s = "))((";
            var expected = string.Empty;

            var returned = ValidParantheses.MinRemoveToMakeValid(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            const string s = "(a(b(c)d)";
            const string expected = "a(b(c)d)";

            var returned = ValidParantheses.MinRemoveToMakeValid(s);
            Assert.Equal(expected, returned);
        }
    }
}
