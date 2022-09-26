using MultipleSourceBfs;
using Xunit;

namespace MultipleSourceBfsTest
{
    public class BfsTest
    {
        [Fact]
        public void Test1()
        {
            var matrix = new int[3][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            };

            var distances = new int[3][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            };

            var returned = MultipleBfs.UpdateMatrix(matrix);
            Assert.Equal(returned, distances); 
        }

        [Fact]
        public void Test2()
        {
            var matrix = new int[3][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
            };

            var distances = new int[3][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 },
            };

            var returned = MultipleBfs.UpdateMatrix(matrix);
            Assert.Equal(returned, distances);
        }
    }
}