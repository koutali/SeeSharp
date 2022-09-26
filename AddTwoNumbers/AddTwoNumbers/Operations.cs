using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoNumbers
{
    public class Operations
    {
        #region public

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                throw new ArgumentException(nameof(l1));
            }

            if (l2 == null)
            {
                throw new ArgumentException(nameof(l2));
            }

            var first = ConvertToList(l1);
            var second = ConvertToList(l2);

            return SumLists(first, second);
        }

        #endregion

        #region private

        private static ListNode SumLists(IReadOnlyCollection<int> first, IReadOnlyCollection<int> second)
        {
            var sumList = SumList(first, second);

            var listNode = new ListNode(sumList.ElementAt(0));
            for (var i = 1; i < sumList.Count; i++)
            {
                listNode.Insert(sumList.ElementAt(i));
            }

            return listNode;
        }

        private static List<int> SumList(IReadOnlyCollection<int> first, IReadOnlyCollection<int> second)
        {
            var sumList = new List<int>();

            var sumCounter = first.Count;
            if (second.Count < first.Count)
            {
                sumCounter = second.Count;
            }

            var carry = false;
            for (var i = 0; i < sumCounter; i++)
            {
                var sum = first.ElementAt(i) + second.ElementAt(i);

                if (carry)
                {
                    sum += 1;
                    carry = false;
                }

                if (sum >= 10)
                {
                    carry = true;
                    sum %= 10;
                }

                sumList.Add(sum);
            }

            // append the rest considering the carry
            carry = AppendRemaining(sumCounter == first.Count ? second : first, sumCounter, carry, sumList);

            if (carry)
            {
                sumList.Add(1);
            }

            return sumList;
        }

        private static bool AppendRemaining(IReadOnlyCollection<int> second, int sumCounter, bool carry, ICollection<int> sumList)
        {
            for (var i = sumCounter; i < second.Count; i++)
            {
                var sum = second.ElementAt(i);

                if (carry)
                {
                    sum += 1;
                    carry = false;
                }

                if (sum >= 10)
                {
                    carry = true;
                    sum %= 10;
                }

                sumList.Add(sum);
            }

            return carry;
        }

        private static List<int> ConvertToList(ListNode listNode)
        {
            var list = new List<int>();

            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }

            return list;
        }

        #endregion
    }
}
