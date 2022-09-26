using System.Collections.Generic;
using System.Linq;

namespace ReverseLinkedList
{
    public class ReversedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            var stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            ListNode headR = null;
            ListNode reversed = null;
            while (stack.Any())
            {
                var toAdd = stack.Pop();
                if (reversed == null)
                { 
                    reversed = new ListNode(toAdd);
                    headR = reversed; 
                    continue;
                }

                while (reversed.next != null)
                {
                    reversed = reversed.next;
                }

                reversed.next = new ListNode(toAdd);
            }

            return headR;
        }
    }
}