using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace _3Sum
{
    public class Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return new List<IList<int>>();
            }

            nums = nums.OrderBy(x => x).ToArray();

            var threeSums = new List<IList<int>>();
            for (var i = 0; i < nums.Length-2; i++)
            {
                if(i > 0 && nums[i] == nums[i-1])
                    continue;

                var low = i + 1;
                var high = nums.Length-1;
                while (low < high)
                {
                    var sum = nums[i] + nums[low] + nums[high];
                    if (sum == 0)
                    {
                        var threeSum = new List<int>() {nums[i], nums[low], nums[high]}.OrderBy(x =>x).ToList();
                        threeSums.Add(threeSum);

                        while (low < high && nums[low] == nums[low+1])
                        {
                            low++;
                        }

                        while (low < high && nums[high] == nums[high-1])
                        {
                            high--;
                        }

                        low++;
                        high--;
                    }
                    else if(sum > 0)
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }
                }
            }

            return threeSums;
        }
    }
}
