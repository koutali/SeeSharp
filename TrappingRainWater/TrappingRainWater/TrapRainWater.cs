namespace TrappingRainWater
{
    public class TrapRainWater
    {
        public static int Trap(int[] heights)
        {
            var minOfMinRightAndLeft = MinOfMinRightAndLeft(heights);

            var sum = 0;
            for (var i = 0; i < heights.Length; i++)
            {
                var difference = minOfMinRightAndLeft[i] - heights[i];
                if (difference > 0)
                {
                    sum += difference;
                }
            }

            return sum;
        }

        private static int[] MinOfMinRightAndLeft(int[] heights)
        {
            var maxLefts = MaxLefts(heights);
            var maxRights = MaxRights(heights);

            var minOfMinRightAndLeft = new int[heights.Length];
            for (var i = 0; i < maxLefts.Length; i++)
            {
                minOfMinRightAndLeft[i] = Math.Min(maxLefts[i], maxRights[i]);
            }

            return minOfMinRightAndLeft;
        }

        private static int[] MaxRights(int[] heights)
        {
            var maxRights = new int[heights.Length];
            var currentMaxRight = 0;
            for (var i = heights.Length - 1; i >= 0; i--)
            {
                maxRights[i] = currentMaxRight;
                if (currentMaxRight < heights[i])
                {
                    currentMaxRight = heights[i];
                }
            }

            return maxRights;
        }

        private static int[] MaxLefts(int[] heights)
        {
            var maxLefts = new int[heights.Length];
            var currentMaxLeft = 0;
            for (var i = 0; i < heights.Length; i++)
            {
                maxLefts[i] = currentMaxLeft;
                if (currentMaxLeft < heights[i])
                {
                    currentMaxLeft = heights[i];
                }
            }

            return maxLefts;
        }
    }
}