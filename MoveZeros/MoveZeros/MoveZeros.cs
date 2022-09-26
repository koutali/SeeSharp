using System;

namespace MoveZeros
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null)
                throw new ArgumentException(nameof(nums));

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    continue;

                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] != 0)
                        continue;

                    var temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }
    }
}
