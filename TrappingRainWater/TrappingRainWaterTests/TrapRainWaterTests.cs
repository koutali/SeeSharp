using TrappingRainWater;

namespace TrappingRainWaterTests
{
    public class TrapRainWaterTests
    {
        [Fact]
        public void Test1()
        {
            var heights = new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            const int expected = 6;
            var returned = TrapRainWater.Trap(heights);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var heights = new[] { 4, 2, 0, 3, 2, 5 };
            const int expected = 9;
            var returned = TrapRainWater.Trap(heights);
            Assert.Equal(expected, returned);
        }
    }
}