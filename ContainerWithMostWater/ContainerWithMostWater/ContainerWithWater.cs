using System.Linq;

namespace ContainerWithMostWater
{
    public class ContainerWithWater
    {
        public static int MaxArea(int[] height)
        {
            var maxArea = 0;

            var left = 0;
            var right = height.Length - 1;
            
            while(right > left)
            {
                var firstSide = right - left;
                var secondSide = height[left];
                if (height[right] < height[left])
                {
                    secondSide = height[right];
                    right--;
                }
                else
                {
                    left++;
                }

                var currentArea = firstSide * secondSide;
                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }
            }

            return maxArea;
        }
    }
}
