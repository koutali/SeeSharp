namespace MergeTwoLinkedLists
{
    public class Merge
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var sentinel = new ListNode();
            var p1 = l1;
            var p2 = l2; 
            var p3 = sentinel;

            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    AppendNode(ref p1, ref p3);
                }
                else
                {
                    AppendNode(ref p2, ref p3);
                }
            }

            while (p1 != null)
            {
                AppendNode(ref p1, ref p3);
            }

            while (p2 != null)
            {
                AppendNode(ref p2, ref p3);
            }

            return sentinel.next;
        }

        private void AppendNode(ref ListNode src, ref ListNode dst)
        {
            var t = new ListNode(src.val);
            dst.next = t;
            dst = dst.next;
            src = src.next;
        }
    }
}