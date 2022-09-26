namespace RemoveElement
{
    public class Remove
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var start = 0;
            var remainingElements = nums.Length;
            var end = 1;

            while (start < nums.Length && end < nums.Length)
            {
                if (nums[start] == val)
                {
                    while (end < nums.Length && nums[end] == val)
                        end++;

                    // swap
                    if (end < nums.Length)
                    {
                        (nums[start], nums[end]) = (nums[end], nums[start]);
                        remainingElements--;
                    }
                }

                start++;
                end = start + 1;
            }

            return remainingElements;
        }
    }
}