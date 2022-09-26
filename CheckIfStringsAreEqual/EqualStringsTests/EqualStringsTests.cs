using Xunit;

namespace CheckIfStringsAreEqual
{
    public class EqualStringsTests
    {
        [Fact]
        public void Test1()
        {
            const string s1 = "abc#";
            const string s2 = "ab";
            Assert.True(EqualStrings.BackspaceCompare(s1, s2));
        }

        [Fact]
        public void Test2()
        {
            const string s1 = "abc#";
            const string s2 = "ac";
            Assert.False(EqualStrings.BackspaceCompare(s1, s2));
        }

        [Fact]
        public void Test3()
        {
            const string s1 = "ab##";
            const string s2 = "c#d#";
            Assert.True(EqualStrings.BackspaceCompare(s1, s2));
        }

        [Fact]
        public void Test4()
        {
            const string s1 = "bxj##tw";
            const string s2 = "bxo#j##tw";
            Assert.True(EqualStrings.BackspaceCompare(s1, s2));
        }
    }
}
