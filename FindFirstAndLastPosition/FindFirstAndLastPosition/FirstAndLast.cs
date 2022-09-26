using System;

namespace FindFirstAndLastPosition
{
    public class FirstAndLast
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            var first = Array.FindIndex(nums, x => x == target);
            var second = Array.FindLastIndex(nums, x => x == target);

            var firstLastIndex = new int[2];
            if(first == -1 && second == -1)
            {
                firstLastIndex[0] = -1;
                firstLastIndex[1] = -1;
            }
            else
            {
                firstLastIndex[0] = first;
                firstLastIndex[1] = second;
            }

            return firstLastIndex;
        }
    }
}
