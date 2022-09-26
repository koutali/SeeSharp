using ContainerWithMostWater;
using Xunit;

namespace ContainerWithMostWaterTests
{
    public class ContainerTests
    {
        [Fact]
        public void Test1()
        {
            var height = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var returned = ContainerWithWater.MaxArea(height);
            Assert.Equal(49, returned);
        }

        [Fact]
        public void Test2()
        {
            var height = new[] { 1, 1 };
            var returned = ContainerWithWater.MaxArea(height);
            Assert.Equal(1, returned);
        }

        [Fact]
        public void Test3()
        {
            var height = new[] { 4, 3, 2, 1, 4 };
            var returned = ContainerWithWater.MaxArea(height);
            Assert.Equal(16, returned);
        }

        [Fact]
        public void Test4()
        {
            var height = new[] { 2, 3, 4, 5, 18, 17, 6 };
            var returned = ContainerWithWater.MaxArea(height);
            Assert.Equal(17, returned);
        }
    }
}
