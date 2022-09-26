using System.Collections.Generic;
using MergeSortedArrays;
using Xunit;

namespace MergeSortedTests
{
    public class MergeSortedTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 1, 2, 3, 0, 0, 0 };
            var input2 = new[] { 2, 5, 6 };
            var expected = new[] { 1, 2, 2, 3, 5, 6 };
            MergeSorted.Merge(ref input, 3, input2, 3);
            Assert.Equal(expected, input);

        }

        [Fact]
        public void Test2()
        {
            var input = new[] { 1 };
            var input2 = new List<int>().ToArray();
            var expected = new[] { 1 };
            MergeSorted.Merge(ref input, 1, input2, 0);
            Assert.Equal(expected, input);

        }
    }
}
