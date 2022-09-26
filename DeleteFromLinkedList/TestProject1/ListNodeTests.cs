using DeleteFromLinkedList;

namespace TestProject1
{
    public class ListNodeTests
    {
        [Fact]
        public void TestDeleteIntermediate()
        {
            ListNode list = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                        {
                            next = null
                        }
                    }
                }
            };

            ListNode toDelete = new ListNode(5);

            list.DeleteNode(toDelete);
            bool valueNotDeleted = false;
            while(list != null)
            {
                if (list.val == toDelete.val)
                    valueNotDeleted = true;

                list = list.next;
            }

            Assert.False(valueNotDeleted);
        }

        [Fact]
        public void TestDeleteHead()
        {
            ListNode list = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                        {
                            next = null
                        }
                    }
                }
            };

            ListNode toDelete = new ListNode(4);

            list.DeleteNode(toDelete);
            bool valueNotDeleted = false;
            while (list != null)
            {
                if (list.val == toDelete.val)
                    valueNotDeleted = true;

                list = list.next;
            }

            Assert.False(valueNotDeleted);
        }

        [Fact]
        public void TestDeleteEnd()
        {
            ListNode list = new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(9)
                        {
                            next = null
                        }
                    }
                }
            };

            ListNode toDelete = new ListNode(9);

            list.DeleteNode(toDelete);
            bool valueNotDeleted = false;
            while (list != null)
            {
                if (list.val == toDelete.val)
                    valueNotDeleted = true;

                list = list.next;
            }

            Assert.False(valueNotDeleted);
        }
    }
}