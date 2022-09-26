using ReverseLinkedList;
using Xunit;

namespace ReverseLinkedListTest
{
    public class ReverseListTests
    {
        [Fact]
        public void Empty_list()
        {
            var linkedList = new ListNode();
            var reversed = ReversedList.ReverseList(linkedList);
            Assert.Equal(linkedList, reversed);
        }

        [Fact]
        public void Two_elements()
        {
            var linkedList = new ListNode(1);
            linkedList.Add(2);

            var expected = new ListNode(2);
            expected.Add(1);

            var reversed = ReversedList.ReverseList(linkedList);
            Assert.Equal(expected, reversed);
        }

        [Fact]
        public void Multiple_elements()
        {
            var linkedList = new ListNode(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            var expected = new ListNode(5);
            expected.Add(4);
            expected.Add(3);
            expected.Add(2);
            expected.Add(1);

            var reversed = ReversedList.ReverseList(linkedList);
            Assert.Equal(expected, reversed);
        }
    }
}
