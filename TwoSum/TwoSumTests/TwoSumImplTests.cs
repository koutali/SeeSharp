using TwoSum;
using Xunit;

namespace TwoSumTests
{
    public class TwoSumImplTests
    {
        [Fact]
        public void Test1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            const int target = 9;
            var expected = new int[] { 0,1};
            var returned = TwoSumImpl.TwoSum(nums, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var nums = new int[] { 3,2,4 };
            const int target = 6;
            var expected = new int[] {1,2 };
            var returned = TwoSumImpl.TwoSum(nums, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            var nums = new int[] { 3,3 };
            const int target = 6;
            var expected = new int[] { 0, 1 };
            var returned = TwoSumImpl.TwoSum(nums, target);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            var nums = new int[] { -1, -2, -3, -4, -5 };
            const int target = -8;
            var expected = new int[] { 2, 4 };
            var returned = TwoSumImpl.TwoSum(nums, target);
            Assert.Equal(expected, returned);
        }
    }
}
