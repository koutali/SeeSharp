using System.Linq;
using Xunit;

namespace MergeIntervalsTests
{
    public class MergeIntervalTests
    {
        [Fact]
        public void Mergeable_arrays()
        {
            var input = new[]
            {
                new[] {1, 3},
                new[] {2, 6},
                new[] {8, 10},
                new[] {15, 18}
            };

            var expected = new[]
            {
                new[] {1, 6},
                new[] {8, 10},
                new[] {15, 18}
            };

            var output = MergeIntervals.MergeIntervals.Merge(input);
            Assert.Equal(expected.Length, output.Length);

            for (var i = 0; i < output.Length; i++)
            {  
                Assert.Equal(expected.ElementAt(i), output.ElementAt(i));
            }
        }

        [Fact]
        public void Mergeable_arrays_small()
        {
            var input = new[]
            {
                new[] {1, 4},
                new[] {4, 5}
            };

            var expected = new[]
            {
                new[] {1, 5}
            };

            var output = MergeIntervals.MergeIntervals.Merge(input);
            Assert.Equal(expected.Length, output.Length);

            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(expected.ElementAt(i), output.ElementAt(i));
            }
        }

        [Fact]
        public void Multiple_merges()
        {
            var input = new[]
            {
                new[] {1, 4},
                new[] {3, 5},
                new[] {5, 6}
            };

            var expected = new[]
            {
                new[] {1, 6}
            };

            var output = MergeIntervals.MergeIntervals.Merge(input);
            Assert.Equal(expected.Length, output.Length);

            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(expected.ElementAt(i), output.ElementAt(i));
            }
        }

        [Fact]
        public void Not_mergable_arrays()
        {
            var input = new[]
            {
                new[] {1, 4},
                new[] {5, 7}
            };

            var expected = new[]
            {
                new[] {1, 4},
                new[] {5, 7}
            };

            var output = MergeIntervals.MergeIntervals.Merge(input);
            Assert.Equal(expected.Length, output.Length);

            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(expected.ElementAt(i), output.ElementAt(i));
            }
        }

        [Fact]
        public void One_contains_all()
        {
            var input = new[]
            {
                new[] {1, 3},
                new[] {2, 19},
                new[] {8, 10},
                new[] {15, 18}
            };

            var expected = new[]
            {
                new[] {1, 19}
            };

            var output = MergeIntervals.MergeIntervals.Merge(input);
            Assert.Equal(expected.Length, output.Length);

            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(expected.ElementAt(i), output.ElementAt(i));
            }
        }
    }
}
