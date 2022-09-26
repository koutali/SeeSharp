using SearchInSortedRotatedArray;
using Xunit;

namespace SearchTests
{
    public class SearchTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 4, 5, 6, 7, 0, 1, 2 };
            const int expected = 4;
            const int target = 0;
            var returned = SearchRotatedArray.Search(input, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var input = new[] { 4, 5, 6, 7, 0, 1, 2 };
            const int expected = -1;
            const int target = 3;
            var returned = SearchRotatedArray.Search(input, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            var input = new[] { 1 };
            const int expected = -1;
            const int target = 0;
            var returned = SearchRotatedArray.Search(input, target);
            Assert.Equal(expected, returned);
        }
    }
}
