using NumberOfProvinvces;
using Xunit;

namespace NumberOfProvincesTest
{
    public class ProvincesTests
    {
        [Fact]
        public void AllDistinctNodes()
        {
            var graph = new[]
            {
                new[]{1,0,0},
                new[]{0,1,0},
                new[]{0,0,1},
            };

            var returned = Provinces.FindCircleNum(graph);
            const int expected = 3;
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void ConnectedNodes()
        {
            var graph = new[]
            {
                new[]{1,1,0},
                new[]{1,1,0},
                new[]{0,0,1},
            };

            var returned = Provinces.FindCircleNum(graph);
            const int expected = 2;
            Assert.Equal(expected, returned);
        }
    }
}
