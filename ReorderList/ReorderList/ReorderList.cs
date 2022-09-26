using System.Collections.Generic;

namespace ReorderList
{
    public class ReorderListC
    {
        #region public

        public static void ReorderList(ListNode head)
        {
            var list = ConvertToList(head);
            ConvertToListNode(list, head);
        }

        #endregion

        #region private

        private static void ConvertToListNode(IList<int> list, ListNode listNode)
        {
            var head = 0;
            var tail = list.Count;
            while (head < list.Count && tail >= 0 && listNode.next.next != null)
            {
                listNode.val = list[head++];
                listNode = listNode.next;
                listNode.val = list[tail]--;
                listNode = listNode.next;
            }
        }

        private static List<int> ConvertToList(ListNode head)
        {
            var list = new List<int>();
            while (head?.next != null)
            {
                list.Add(head.val);
            }

            return list;
        }

        #endregion
    }
}
