using CloneGraph;
using Xunit;

namespace CloneGraphTests
{
    public class CloneTests
    {
        [Fact]
        public void Test1()
        {
            var first = new Node(1);
            var second = new Node(2);
            var third = new Node(3);
            var fourth = new Node(4);

            first.neighbors.Add(second);
            first.neighbors.Add(third);

            second.neighbors.Add(first);
            second.neighbors.Add(fourth);

            third.neighbors.Add(first);
            third.neighbors.Add(fourth);

            fourth.neighbors.Add(second);
            fourth.neighbors.Add(third);

            var returnedNode = Clone.CloneGraph(first);

            Assert.True(Clone.AreEqual(first, returnedNode));
        }
    }
}
