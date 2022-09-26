using System.Collections.Generic;

namespace MergeSortedArrays
{
    public class MergeSorted
    {
        public static void Merge(ref int[] nums1, int m, int[] nums2, int n)
        {
            var firstIndex = 0;
            var secondIndex = 0;

            var list = new List<int>();
            while (firstIndex < m && secondIndex < n)
            {
                if (nums1[firstIndex] < nums2[secondIndex])
                {
                    list.Add(nums1[firstIndex++]);
                }
                else
                {
                    list.Add(nums2[secondIndex++]);
                }
            }

            while (firstIndex < m)
            {
                list.Add(nums1[firstIndex++]);
            }

            while (secondIndex < n)
            {
                list.Add(nums2[secondIndex++]);
            }

            nums1 = list.ToArray();
        }
    }
}
