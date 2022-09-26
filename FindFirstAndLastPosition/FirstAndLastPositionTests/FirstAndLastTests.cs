using FindFirstAndLastPosition;
using Xunit;

namespace FirstAndLastPositionTests
{
    public class FirstAndLastTests
    {
        [Fact]
        public void Test1()
        {
            var nums = new int[] { 5, 7, 7, 8, 8, 10 };
            const int target = 8;
            var expected = new int[] {3, 4};
            var returned = FirstAndLast.SearchRange(nums, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var nums = new int[] { 5, 7, 7, 8, 8, 10 };
            const int target = 6;
            var expected = new int[] { -1, -1 };
            var returned = FirstAndLast.SearchRange(nums, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            var nums = new int[] { };
            const int target = 0;
            var expected = new int[] { -1, -1 };
            var returned = FirstAndLast.SearchRange(nums, target);
            Assert.Equal(expected, returned);
        }
    }
}
