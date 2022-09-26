using MaximizeDistanceToClosestPerson;
using Xunit;

namespace MaxDistanceToClosestPersonTests
{
    public class MaxDistanceTests
    {
        [Fact]
        public void Test1()
        {
            var seats = new[] { 0, 1 };
            var maxDistance = MaxDistance.MaxDistToClosest(seats);
            Assert.Equal(1, maxDistance);
        }

        [Fact]
        public void Test2()
        {
            var seats = new[] { 1, 0, 0, 0, 1, 0, 1 };
            var maxDistance = MaxDistance.MaxDistToClosest(seats);
            Assert.Equal(2, maxDistance);
        }

        [Fact]
        public void Test3()
        {
            var seats = new[] { 1, 0, 0, 0 };
            var maxDistance = MaxDistance.MaxDistToClosest(seats);
            Assert.Equal(3, maxDistance);
        }

        [Fact]
        public void Test4()
        {
            var seats = new[] { 1, 0, 1, 0, 0, 0, 1 };
            var maxDistance = MaxDistance.MaxDistToClosest(seats);
            Assert.Equal(2, maxDistance);
        }

        [Fact]
        public void Test5()
        {
            var seats = new[] { 0, 0, 1 };
            var maxDistance = MaxDistance.MaxDistToClosest(seats);
            Assert.Equal(2, maxDistance);
        }
    }
}