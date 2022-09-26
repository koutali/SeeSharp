namespace FindMedianSortedArray
{
    public class MedianSortedArray
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums1Ptr = 0;
            var nums2Ptr = 0;
            var i = 0;

            var merged = new int[nums1.Length + nums2.Length];
            while (nums1Ptr < nums1.Length && nums2Ptr < nums2.Length && i < merged.Length)
            {
                if (nums1[nums1Ptr] < nums2[nums2Ptr])
                {
                    merged[i] = nums1[nums1Ptr];
                    nums1Ptr++;
                }
                else
                {
                    merged[i] = nums2[nums2Ptr];
                    nums2Ptr++;
                }

                i++;
            }

            while (nums1Ptr < nums1.Length && i < merged.Length)
            {
                merged[i] = nums1[nums1Ptr];
                i++;
                nums1Ptr++;
            }

            while (nums2Ptr < nums2.Length && i < merged.Length)
            {
                merged[i] = nums2[nums2Ptr];
                i++;
                nums2Ptr++;
            }

            var mid = merged.Length / 2;
            if (merged.Length % 2 == 1)
            {
                return merged[mid];
            }

            return (merged[mid] + merged[mid - 1]) / 2.0;
        }
    }
}
