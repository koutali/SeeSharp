
using LongPressedName;
using Xunit;

namespace LongPressedNameTest
{
    public class CheckTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Check.IsLongPressedName("alex", "aaleex"));
        }

        [Fact]
        public void Test2()
        {
            Assert.False(Check.IsLongPressedName("saeed", "ssaaedd"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Check.IsLongPressedName("a", "b"));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(Check.IsLongPressedName("ppyplrza", "pyypllrza"));
        }

        [Fact]
        public void Test5()
        {
            Assert.False(Check.IsLongPressedName("zlexya", "aazlllllllllllllleexxxxxxxxxxxxxxxya"));
        }
    }
}