using KthLargestElement;

namespace KthLargestElementTests
{
    public class KthLargestTests
    {
        [Fact]
        public void Test1()
        {
            var nums = new int[] { 3, 2, 1, 5, 6, 4 };
            Assert.Equal(5, KthLargest.FindKthLargest(nums, 2));
        }

        [Fact]
        public void Test2()
        {
            var nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            Assert.Equal(4, KthLargest.FindKthLargest(nums, 4));
        }
    }
}