using NumberOfIsland;
using Xunit;

namespace NumberOfIslandTests
{
    public class IslandTests
    {
        [Fact]
        public void AllConnected()
        {
            var grid = new char[4][]
            {
                new []{'1', '1', '1', '1', '0'},
                new []{'1', '1', '0', '1', '0'},
                new []{'1', '1', '0', '0', '0'},
                new []{'0', '0', '0', '0', '0'}
            };

            var returned = Islands.NumIslands(grid);
            Assert.Equal(1, returned);
        }

        [Fact]
        public void AllDisconnected()
        {
            var grid = new char[4][]
            {
                new []{'1', '1', '0', '0', '0'},
                new []{'1', '1', '0', '0', '0'},
                new []{'0', '0', '1', '0', '0'},
                new []{'0', '0', '0', '1', '1'}
            };

            var returned = Islands.NumIslands(grid);
            Assert.Equal(3, returned);
        }
    }
}
