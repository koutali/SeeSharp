using ClimbStairs;
using Xunit;

namespace ClimbStairsTests
{
    public class ClimbTests
    {
        [Fact]
        public void Test1()
        {
            int ways = Climb.ClimbStairs(3);
            Assert.Equal(3,ways);
        }
    }
}