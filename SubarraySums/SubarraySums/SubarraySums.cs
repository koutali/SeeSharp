using System.Linq;

namespace SubarraySumsNamespace
{
    public class SubarraySums
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {

            var left = 0;
            var right = 0;

            var sum = 0;
            for (; right < nums.Length && left < nums.Length; right++)
            {
                if (sum == k)
                {
                    return true;
                }

                if (sum > k)
                {
                    sum -= nums[left];
                    left++;
                }
                else
                {
                    sum += nums[right];
                }
            }

            return false;
        }

        public static int SubarraySum(int[] nums, int k)
        {
            var left = 0;
            var right = 0;

            var matches = nums.Count(x => x == k);
            var sum = 0;
            for (; right < nums.Length && left < nums.Length; right++)
            {
                if (sum < k)
                {
                    sum += nums[right];
                }
                else if (sum > k)
                {
                    sum -= nums[left];
                    left++;
                }

                if (sum != k) 
                    continue;

                matches++;
                sum -= nums[left];
                left++;
            }

            return matches;
        }
    }
}
