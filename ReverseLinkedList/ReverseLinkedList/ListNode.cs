using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int Count()
        {
            var count = 0;
            var head = this;
            while (head.next != null)
            {
                head = head.next;
                count++;
            }

            return count;
        }

        public void Add(int value)
        {
            var head = this;
            while (head.next != null)
            {
                head = head.next;
            }

            head.next = new ListNode(value);
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || GetType() != obj.GetType())
            {
                return false;
            }

            var head = this;
            var p = (ListNode)obj;
            if (head.Count() != p.Count())
                return false;
                
            while (head?.next != null && p?.next != null)
            {
                if (head.val != p.val)
                    return false;

                head = head.next;
                p = p.next;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(val, next);
        }
    }
}