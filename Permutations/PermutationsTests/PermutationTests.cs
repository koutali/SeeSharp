using System;
using System.Collections.Generic;
using System.Linq;
using Permutations;
using Xunit;

namespace PermutationsTests
{
    public class PermutationTests
    {
        [Fact]
        public void Null_array_throws_exception()
        {
            var permutation = new Permutation();
            Assert.Throws<ArgumentException>(() => permutation.Permute(null));
        }

        [Fact]
        public void Empty_input_returns_empty_output()
        {
            var permutation = new Permutation();
            var input = new List<int>();
            var returned = permutation.Permute(input.ToArray());
            Assert.Empty(returned.ElementAt(0));
        }

        [Fact]
        public void Input_of_size_one_returns_output_of_size_one()
        {
            var permutation = new Permutation();
            var input = new List<int>(){1};
            var returned = permutation.Permute(input.ToArray());

            Assert.Single(returned);
            Assert.Equal(input, returned.ElementAt(0));
        }

        [Fact]
        public void Valid_input()
        {
            var permutation = new Permutation();
            var input = new List<int>() { 1,2,3 };

            var expected = new List<IList<int>>()
            {
                new List<int>(){1,2,3},
                new List<int>(){1,3,2},
                new List<int>(){2,1,3},
                new List<int>(){2,3,1},
                new List<int>(){3,1,2},
                new List<int>(){3,2,1},
            };
            var returned = permutation.Permute(input.ToArray());

            Assert.Equal(expected.Count, returned.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, returned);
            }
        }

        [Fact]
        public void Valid_input_permute_unique()
        {
            var permutation = new Permutation();
            var input = new List<int>() { 1, 1, 2 };

            var expected = new List<IList<int>>()
            {
                new List<int>(){1,1,2},
                new List<int>(){1,2,1},
                new List<int>(){2,1,1},
            };
            var returned = permutation.PermuteUnique(input.ToArray());

            Assert.Equal(expected.Count, returned.Count);
            foreach (var list in expected)
            {
                Assert.Contains(list, returned);
            }
        }
    }
}
