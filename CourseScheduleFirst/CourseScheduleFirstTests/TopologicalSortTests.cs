using CourseScheduleFirst;
using Xunit;

namespace CourseScheduleFirstTests
{
    public class TopologicalSortTests
    {
        [Fact]
        public void Test1()
        {
            var cycle = new int[1][];
            cycle[0] = new[] { 1, 0 };

            var returnedOrder = TopologicalSort.FindOrder(2, cycle);
            var expectedOrder = new[] { 0,1 };
            Assert.Equal(expectedOrder, returnedOrder);
        }

        [Fact]
        public void Test2()
        {
            var cycle = new int[4][];
            cycle[0] = new[] { 1, 0 };
            cycle[1] = new[] { 2, 0 };
            cycle[2] = new[] { 3, 1 };
            cycle[3] = new[] { 3, 2 };

            var returnedOrder = TopologicalSort.FindOrder(4, cycle);
            var expectedOrder = new[] { 0, 2, 1,3 };
            Assert.Equal(expectedOrder, returnedOrder);
        }
    }
}
