using BackspaceCompare;
using Xunit;

namespace BackspaceCompareTest
{
    public class CompareTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "ab#c";
            const string t = "ad#c";
            Assert.True(Compare.BackspaceCompare(s,t));
        }

        [Fact]
        public void Test2()
        {
            const string s = "ab##";
            const string t = "c#d#";
            Assert.True(Compare.BackspaceCompare(s, t));
        }

        [Fact]
        public void Test3()
        {
            const string s = "a##c";
            const string t = "#a#c";
            Assert.True(Compare.BackspaceCompare(s, t));
        }

        [Fact]
        public void Test4()
        {
            const string s = "a#c";
            const string t = "b";
            Assert.False(Compare.BackspaceCompare(s, t));
        }
    }
}
