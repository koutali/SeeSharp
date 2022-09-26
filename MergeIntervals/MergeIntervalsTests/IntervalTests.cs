using MergeIntervals;
using Xunit;

namespace MergeIntervalsTests
{
    public class IntervalTests
    {
        [Fact]
        public void Test1()
        {
            //[[1,3],[2,6],[8,10],[15,18]]
            var intervals = new[]
            {
                new[] {1,3},
                new[] {15,18},
                new[] {8,10},
                new[] {2,6}
            };
            
           var returned = Interval.Merge(intervals);

           // [[1,6],[8,10],[15,18]]
           var expected = new[]
           {
               new[] {1,6},
               new[] {8,10},
               new[] {15,18},
           };

           Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            //[[1,4],[4,5]]
            var intervals = new[]
            {
                new[] {1,4},
                new[] {4,5}
            };

            var returned = Interval.Merge(intervals);

            var expected = new[]
            {
                new[] { 1, 5 }
            };

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            //[[1,4],[4,5]]
            var intervals = new[]
            {
                new[] {1,4},
                new[] {2,3}
            };

            var returned = Interval.Merge(intervals);

            var expected = new[]
            {
                new[] { 1, 4 }
            };

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            //[[1,4],[0,2],[3,5]]
            var intervals = new[]
            {
                new[] {1,4},
                new[] {0,2},
                new[] {3,5}
            };

            var returned = Interval.Merge(intervals);

            var expected = new[]
            {
                new[] { 0, 5 }
            };

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test5()
        {
            //[[2,3],[4,5],[6,7],[8,9],[1,10]]
            var intervals = new[]
            {
                new[] {2,3},
                new[] {4,5},
                new[] {6,7},
                new[] {8,9},
                new[] {1,10}
            };

            var returned = Interval.Merge(intervals);

            var expected = new[]
            {
                new[] { 1, 10 }
            };

            Assert.Equal(expected, returned);
        }
    }
}