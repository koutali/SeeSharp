using RemoveDuplicatesFromSortedArray;
using Xunit;

namespace RemoveDuplicatesTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { 1, 1, 2 };
            const int expected = 2;
            var returned = RemoveDuplicatesClass.RemoveDuplicates(input);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var input = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            const int expected = 5;
            var returned = RemoveDuplicatesClass.RemoveDuplicates(input);
            Assert.Equal(expected, returned);
        }
    }
}
