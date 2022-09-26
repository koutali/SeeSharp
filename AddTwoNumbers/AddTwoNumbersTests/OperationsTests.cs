using AddTwoNumbers;
using Xunit;

namespace AddTwoNumbersTests
{
    public class OperationsTests
    {
        [Fact]
        public void Test1()
        {
            var first = new ListNode(2);
            first.Insert(4);
            first.Insert(3);

            var second = new ListNode(5);
            second.Insert(6);
            second.Insert(4);

            var expected = new ListNode(7);
            expected.Insert(0);
            expected.Insert(8);

            var returned = Operations.AddTwoNumbers(first, second);
            Assert.Equal(expected.Size, returned.Size);
            while (returned != null && expected != null)
            {
                Assert.Equal(expected.val, returned.val);
                expected = expected.next;
                returned = returned.next;
            }
        }

        [Fact]
        public void Test2()
        {
            var first = new ListNode(0);
            var second = new ListNode(0);

            var expected = new ListNode(0);
            var returned = Operations.AddTwoNumbers(first, second);

            Assert.Equal(expected.Size, returned.Size);
            while (returned != null && expected != null)
            {
                Assert.Equal(expected.val, returned.val);
                expected = expected.next;
                returned = returned.next;
            }
        }

        [Fact]
        public void Test4()
        {
            var first = new ListNode(9);

            var second = new ListNode(1);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);

            var expected = new ListNode(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(1);

            var returned = Operations.AddTwoNumbers(first, second);
            Assert.Equal(expected.Size, returned.Size);
            while (returned != null && expected != null)
            {
                Assert.Equal(expected.val, returned.val);
                expected = expected.next;
                returned = returned.next;
            }
        }

        [Fact]
        public void Test3()
        {
            var first = new ListNode(9);
            first.Insert(9);
            first.Insert(9);
            first.Insert(9);
            first.Insert(9);
            first.Insert(9);
            first.Insert(9);

            var second = new ListNode(9);
            second.Insert(9);
            second.Insert(9);
            second.Insert(9);

            var expected = new ListNode(8);
            expected.Insert(9);
            expected.Insert(9);
            expected.Insert(9);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(0);
            expected.Insert(1);

            var returned = Operations.AddTwoNumbers(first, second);

            Assert.Equal(expected.Size, returned.Size);
            while (returned != null && expected != null)
            {
                Assert.Equal(expected.val, returned.val);
                expected = expected.next;
                returned = returned.next;
            }
        }
    }
}
