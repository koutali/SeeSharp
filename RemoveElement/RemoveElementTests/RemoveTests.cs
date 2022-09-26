using RemoveElement;
using Xunit;

namespace RemoveElementTests
{
    public class RemoveTests
    {
        [Fact]
        public void Test1()
        {
            int[] nums = { 3, 2, 2, 3 };
            var toRemove = 3;

            var newLength = Remove.RemoveElement(nums, toRemove);
            Assert.Equal(2, newLength);
            Assert.Equal(new[] { 2, 2, 3, 3 }, nums);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            var toRemove = 2;

            var newLength = Remove.RemoveElement(nums, toRemove);
            Assert.Equal(5, newLength);
            Assert.Equal(new[] { 0, 1, 3, 0, 4, 2, 2, 2 }, nums);
        }
    }
}