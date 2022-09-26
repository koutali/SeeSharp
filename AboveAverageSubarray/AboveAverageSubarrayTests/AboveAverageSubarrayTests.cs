using AboveAverageSubArray;
using System;
using System.Collections.Generic;
using Xunit;

namespace AboveAverageSubArrayTests
{
    public class AboveAverageSubArrayTests
    {
        [Fact]
        public void Null_array_throws_exception()
        {
            Assert.Throws<ArgumentException>(() => AboveAverageSubArray.AboveAverageSubArray.AboveAverageSubArrays(null));
        }

        [Fact]
        public void Empty_array_throws_exception()
        {
            var list = new List<int>();
            Assert.Throws<ArgumentException>(() => AboveAverageSubArray.AboveAverageSubArray.AboveAverageSubArrays(list.ToArray()));
        }

        [Fact]
        public void Array_of_size_one_returns_itself()
        {
            var array = new int[] {1};

            var returned = AboveAverageSubArray.AboveAverageSubArray.AboveAverageSubArrays(array);
            var expected = new List<SubArray> {new SubArray(1, 1)}.ToArray();

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Array_with_multiple_elements()
        {
            var array = new int[] { 3,4,2 };

            var returned = AboveAverageSubArray.AboveAverageSubArray.AboveAverageSubArrays(array);
            var expected = new List<SubArray>
            {
                new SubArray(1, 2),
                new SubArray(1, 3),
                new SubArray(2, 2),
            }.ToArray();

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Array_with_multiple_elements_all_same_value()
        {
            var array = new int[] { 2, 2, 2 };
            var returned = AboveAverageSubArray.AboveAverageSubArray.AboveAverageSubArrays(array);
            var expected = new List<SubArray>
            {
                new SubArray(1, 3)
            }.ToArray();

            Assert.Equal(expected, returned);
        }
    }
}
