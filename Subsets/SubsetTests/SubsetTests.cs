using System.Collections.Generic;
using Subsets;
using Xunit;

namespace SubsetTests
{
    public class SubsetTests
    {
        [Fact]
        public void Test1()
        {
            var list = new List<int>() {1, 2, 3};

            var expected = new List<List<int>>
            {
                new(),
                new() {1},
                new() {2},
                new() {1,2},
                new() {3},
                new() {1,3},
                new() {2,3},
                new() { 1, 2, 3 }
            };

            var returned = SubsetsNamespace.Subsets(list.ToArray());

            Assert.Equal(returned, expected);
            foreach (var element in expected)
            {
                Assert.True(returned.Contains(element));
            }
        }

        [Fact]
        public void Test2()
        {
            var list = new List<int>() { 0 };

            var expected = new List<List<int>>
            {
                new(),
                new() {0}
            };

            var returned = SubsetsNamespace.Subsets(list.ToArray());

            Assert.Equal(returned, expected);
            foreach (var element in expected)
            {
                Assert.True(returned.Contains(element));
            }
        }
    }
}
