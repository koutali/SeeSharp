using MinCostClimbingStairs;
using Xunit;

namespace MinCostClimbingStairsTests
{
    public class MinCostTests
    {
        [Fact]
        public void Test1()
        {
            int[] costs = { 10, 15, 30 };
            var minCost = MinCost.MinCostClimbingStairs(costs);
            Assert.Equal(15, minCost);
        }

        [Fact]
        public void Test2()
        {
            int[] costs = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var minCost = MinCost.MinCostClimbingStairs(costs);
            Assert.Equal(6, minCost);
        }
    }
}