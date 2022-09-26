using LastStoneWeight;
using Xunit;

namespace LastStoneWeightTest
{
    public class LastStoneTests
    {
        [Fact]
        public void Test1()
        {
            var stones = new[] { 2, 7, 4, 1, 8, 1 };
            var optimalWeight = LastStone.LastStoneWeightII(stones);
            Assert.Equal(1, optimalWeight);
        }

        [Fact]
        public void Test2()
        {
            var stones = new[] { 31, 26, 33, 21, 40 };
            var optimalWeight = LastStone.LastStoneWeightII(stones);
            Assert.Equal(5, optimalWeight);
        }
    }
}