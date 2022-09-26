using TotalFruit;
using Xunit;

namespace TotalFruitTests
{
    public class FruitSumTests
    {
        [Fact]
        public void Test1()
        {
            var trees = new[] { 1, 2, 1 };
            var returned = FruitSum.TotalFruit(trees);
            Assert.Equal(3, returned);
        }

        [Fact]
        public void Test2()
        {
            var trees = new[] { 0, 1, 2, 2 };
            var returned = FruitSum.TotalFruit(trees);
            Assert.Equal(3, returned);
        }

        [Fact]
        public void Test3()
        {
            var trees = new[] { 1, 2, 3, 2, 2 };
            var returned = FruitSum.TotalFruit(trees);
            Assert.Equal(4, returned);
        }

        [Fact]
        public void Test4()
        {
            var trees = new[] { 1, 2, 3 };
            var returned = FruitSum.TotalFruit(trees);
            Assert.Equal(2, returned);
        }

        [Fact]
        public void Test5()
        {
            var trees = new[] { 1, 0, 3, 4, 3 };
            var returned = FruitSum.TotalFruit(trees);
            Assert.Equal(3, returned);
        }
    }
}