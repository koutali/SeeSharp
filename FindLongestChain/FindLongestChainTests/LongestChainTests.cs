using FindLongestChain;
using Xunit;

namespace FindLongestChainTests
{
    public class LongestChainTests
    {
        [Fact]
        public void Test1()
        {
            var list = new[]
            {
                new[] { 1, 2 },
                new[] { 3, 4 },
                new[] { 2, 3 }
            };

            var chainLength = LongestChain.FindLongestChain(list);
            Assert.Equal(2, chainLength);
        }

        [Fact]
        public void Test2()
        {
            var list = new[]
            {
                new[] { 1, 2 },
                new[] { 7, 8 },
                new[] { 4, 5 }
            };

            var chainLength = LongestChain.FindLongestChain(list);
            Assert.Equal(3, chainLength);
        }

        [Fact]
        public void Test3()
        {

            // [[-10,-8],[8,9],[-5,0],[6,10],[-6,-4],[1,7],[9,10],[-4,7]]
            var list = new[]
            {
                new[] { -10, -8 },
                new[] { 8, 9 },
                new[] { -5, 0 },
                new []{6,10},
                new []{-6,-4},
                new []{1,7},
                new []{9,10},
                new []{-4,7}
            };

            var chainLength = LongestChain.FindLongestChain(list);
            Assert.Equal(4, chainLength);
        }
    }
}