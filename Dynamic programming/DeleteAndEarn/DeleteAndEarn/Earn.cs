namespace DeleteAndEarn
{
    public class Earn
    {
        private readonly Dictionary<int, int> occurences = new();

        public int DeleteAndEarn(int[] nums)
        {
            // sort and eliminate duplicates
            nums = nums.OrderBy(x => x).ToArray();
            CreateOccurences(nums);
            nums = nums.Distinct().ToArray();

            var previousEarn = 0;
            var previousPreviousEarn = 0;
            var currentEarn = 0;

            for (var i = 0; i < nums.Length; i++)
            {

                currentEarn = occurences[nums[i]] * nums[i];
                // not allowed to take currentEarn and the value before
                // temp since we shift the value 
                if (i > 0 && nums[i] == nums[i - 1] + 1)
                {
                    // either take the sum of current earn and the two previous value or 
                    // directly the previous value
                    var temp = previousEarn;
                    previousEarn = Math.Max(currentEarn + previousPreviousEarn, previousEarn);
                    previousPreviousEarn = temp;
                }
                else
                {
                    // allowed to take current earn and the 
                    var temp = previousEarn;
                    previousEarn = currentEarn + previousEarn;
                    previousPreviousEarn = temp;
                }
            }

            return previousEarn;
        }

        private void CreateOccurences(int[] nums)
        {
            foreach (var num in nums)
            {
                if (occurences.ContainsKey(num))
                {
                    occurences[num]++;
                }
                else
                {
                    occurences.Add(num, 1);
                }
            }
        }
    }
}