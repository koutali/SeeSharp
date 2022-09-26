namespace SummaryRanges
{
    public class Ranges
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> ranges = new List<string>();

            var current = 0;
            while (current < nums.Length - 1)
            {
                var next = current + 1;
                if (nums[current] != nums[next] - 1)
                {
                    ranges.Add(nums[current].ToString());
                    current++;
                }
                else
                {
                    // find range start and end
                    var delta = 1;
                    while (next < nums.Length && nums[current] == nums[next] - delta)
                    {
                        delta++;
                        next++;
                    }

                    next--;
                    ranges.Add(nums[current] + "->" + nums[next]);
                    current = next+1;
                }
            }

            while(current < nums.Length)
            {
                ranges.Add(nums[current].ToString());
                current++;
            }

            return ranges;
        }
    }
}