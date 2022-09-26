namespace LastStoneWeight
{
    public class LastStone
    {
        public static int LastStoneWeightII(int[] stones)
        {
            var sum = stones.Sum();

            var half = sum / 2;
            var dp = new bool[half + 1];
            dp[0] = true;
            var currentMax = 0;

            foreach (var stone in stones)
            {
                var clone = (bool[])dp.Clone();
                for(var partialSum = stone; partialSum <= half; partialSum++)
                {
                    if (!dp[partialSum - stone]) 
                        continue;

                    clone[partialSum] = true;
                    currentMax = Math.Max(currentMax, partialSum);
                    if (currentMax == half)
                        break;
                }

                dp = clone;
            }

            return sum - 2 * currentMax;
        }
    }
}