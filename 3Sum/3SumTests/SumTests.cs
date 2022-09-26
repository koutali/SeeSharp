using System.Collections.Generic;
using _3Sum;
using Xunit;

namespace _3SumTests
{
    public class SumTests
    {
        [Fact]
        public void Empty_list()
        {
            var arr = new int[] { };
            var returned = Sum.ThreeSum(arr);
            Assert.Empty(returned);
        }

        [Fact]
        public void One_element()
        {
            var arr = new[] { 0 };
            var returned = Sum.ThreeSum(arr);
            Assert.Empty(returned);
        }

        [Fact]
        public void Two_elements()
        {
            var arr = new[] { 0, 1 };
            var returned = Sum.ThreeSum(arr);
            Assert.Empty(returned);
        }

        [Fact]
        public void Other()
        {
            var arr = new[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            };

            var returned = Sum.ThreeSum(arr);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Failed()
        {
            var arr = new[] { 1, 2, -2, -1 };
            var expected = new List<IList<int>>
            { };

            var returned = Sum.ThreeSum(arr);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Failed2()
        {
            var arr = new[] { 3, 0, -2, -1, 1, 2 };
            var expected = new List<IList<int>>
                {
                    new List<int> { -2, -1, 3 },
                    new List<int> { -2, 0, 2 },
                    new List<int> { -1, 0, 1 }
                    };

            var returned = Sum.ThreeSum(arr);
            Assert.Equal(expected, returned);
        }
    }
}
