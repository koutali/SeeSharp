using MergeTwoLinkedLists;

namespace MergeTwoLinkedListsTests
{
    public class MergeTests
    {
        [Fact]
        public void Test1()
        {
            var list1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode(4)
                }
            };

            var list2 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode(4)
                }
            };

            var expected = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode(4)
                            }
                        }
                    }
                }
            };

            var returned = Merge.MergeTwoLists(list1, list2);
            var error = false;
            while(returned != null && expected != null)
            {
                if(returned.val != expected.val)
                {
                    error = true;
                    break;
                }

                returned = returned.next;
                expected = expected.next;
            }

            Assert.False(error);
            Assert.Null(returned);
            Assert.Null(expected);
        }
    }
}