using DeleteAndEarn;
using Xunit;

namespace DeleteAndEarnTests
{
    public class EarnTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 3, 4, 2 };
            var earn = new Earn();
            var earned = earn.DeleteAndEarn(input);
            Assert.Equal(6,earned);
        }

        [Fact]
        public void Test2()
        {
            var input = new[] { 2, 2, 3, 3, 3, 4 };
            var earn = new Earn();
            var earned = earn.DeleteAndEarn(input);
            Assert.Equal(9, earned);
        }

        [Fact]
        public void Test3()
        {
            var input = new[] {3,1 };
            var earn = new Earn();
            var earned = earn.DeleteAndEarn(input);
            Assert.Equal(4, earned);
        }
    }
}