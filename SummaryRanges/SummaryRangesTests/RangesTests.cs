using System.Collections.Generic;
using SummaryRanges;
using Xunit;

namespace SummaryRangesTests
{
    public class RangesTests
    {
        [Fact]
        public void Test1()
        {
            int [] nums = { 0, 1, 2, 4, 5, 7 };
            IList<string> expected = new List<string>()
            {
                "0->2","4->5","7"
            };

            var returned = Ranges.SummaryRanges(nums);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
            IList<string> expected = new List<string>()
            {
                "0","2->4","6","8->9"
            };

            var returned = Ranges.SummaryRanges(nums);
            Assert.Equal(expected, returned);
        }
    }
}