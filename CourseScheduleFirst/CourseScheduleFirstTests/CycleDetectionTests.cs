using CourseScheduleFirst;
using Xunit;

namespace CourseScheduleFirstTests
{
    public class CycleDetectionTests
    {
        [Fact]
        public void Test1()
        {
            var cycle = new int[1][];
            cycle[0] = new int[2] { 1,0 };

            var returned = CycleDetection.CanFinish(2, cycle);
            Assert.True(returned);
        }

        [Fact]
        public void Test2()
        {
            var cycle = new int[2][];
            cycle[0] = new int[2] { 0, 1 };
            cycle[1] = new int[2] { 1, 0 };

            var returned = CycleDetection.CanFinish(2, cycle);
            Assert.False(returned);
        }

        [Fact]
        public void Test3()
        { 
            var cycle = new int[4][];
            cycle[0] = new[] { 1, 4 };
            cycle[1] = new[] { 2, 4 };

            cycle[2] = new[] { 3, 1 };
            cycle[3] = new[] { 3, 2 };

            var returned = CycleDetection.CanFinish(5, cycle);
            Assert.True(returned);
        }

        [Fact]
        public void Test4()
        {
            var cycle = new int[20][];

            cycle[0] = new[] { 0, 10 };
            cycle[1] = new[] { 3, 18 };

            cycle[2] = new[] { 5, 5 };
            cycle[3] = new[] { 6, 11 };

            cycle[4] = new[] { 11, 14 };
            cycle[5] = new[] { 13, 1 };

            cycle[6] = new[] { 15, 1 };
            cycle[7] = new[] {17, 4 };
            var returned = CycleDetection.CanFinish(20, cycle);
            Assert.False(returned);
        }

        [Fact]
        public void Test5()
        {
            var cycle = new int[5][];
            cycle[0] = new[] { 2, 0 };
            cycle[1] = new[] { 1, 0 };
            cycle[2] = new[] { 3, 1 };
            cycle[3] = new[] { 3, 2 };
            cycle[4] = new[] { 1, 3 };

            var returned = CycleDetection.CanFinish(4, cycle);
            Assert.False(returned);
        }
    }
}