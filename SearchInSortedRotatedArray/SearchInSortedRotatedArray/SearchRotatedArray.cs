using System.Collections.Generic;

namespace SearchInSortedRotatedArray
{
    public class SearchRotatedArray
    {
        private static int FindRotateIndex(int left, int right, IReadOnlyList<int> nums)
        {
            if (nums[left] < nums[right])
                return 0;

            while (left <= right)
            {
                var pivot = (left + right) / 2;
                if (nums[pivot] > nums[pivot + 1])
                    return pivot + 1;
                else
                {
                    if (nums[pivot] < nums[left])
                        right = pivot - 1;
                    else
                        left = pivot + 1;
                }
            }
            return 0;
        }

        private static int Search(int left, int right, IReadOnlyList<int> nums, int target)
        {
            while (left <= right)
            {
                var pivot = (left + right) / 2;
                if (nums[pivot] == target)
                    return pivot;
                else
                {
                    if (target < nums[pivot])
                        right = pivot - 1;
                    else
                        left = pivot + 1;
                }
            }
            return -1;
        }

        public static int Search(int[] nums, int target)
        {
            var n = nums.Length;

            if (n == 1)
                return nums[0] == target ? 0 : -1;

            var rotateIndex = FindRotateIndex(0, n - 1, nums);

            // if target is the smallest element
            if (nums[rotateIndex] == target)
                return rotateIndex;

            // if array is not rotated, search in the entire array
            if (rotateIndex == 0)
                return Search(0, n - 1, nums, target);

            return target < nums[0] ? Search(rotateIndex, n - 1, nums, target) : Search(0, rotateIndex, nums, target);

        }
    }
}
