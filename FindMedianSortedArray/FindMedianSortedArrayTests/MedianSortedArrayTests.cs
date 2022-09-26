using FindMedianSortedArray;
using System.Collections.Generic;
using Xunit;

namespace FindMedianSortedArrayTests
{
    public class MedianSortedArrayTests
    {
        [Fact]
        public void Test1()
        {
            var arr1 = new[] { 1, 3 };
            var arr2 = new[] { 2 };
            const double expected = 2;
            var returned = MedianSortedArray.FindMedianSortedArrays(arr1, arr2);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var arr1 = new[] { 1, 2 };
            var arr2 = new[] { 3, 4 };
            const double expected = 2.5;
            var returned = MedianSortedArray.FindMedianSortedArrays(arr1, arr2);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            var arr1 = new[] { 0, 0 };
            var arr2 = new[] { 0, 0 };
            const double expected = 0;
            var returned = MedianSortedArray.FindMedianSortedArrays(arr1, arr2);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            var arr1 = new List<int>();
            var arr2 = new[] { 1 };
            const double expected = 1;
            var returned = MedianSortedArray.FindMedianSortedArrays(arr1.ToArray(), arr2);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test5()
        {
            var arr2 = new List<int>();
            var arr1 = new[] { 2 };
            const double expected = 2;
            var returned = MedianSortedArray.FindMedianSortedArrays(arr1, arr2.ToArray());
            Assert.Equal(expected, returned);
        }
    }
}
