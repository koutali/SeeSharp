using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class TwoSumImpl
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var hashMap = new Dictionary<int, List<int>>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!hashMap.ContainsKey(nums[i]))
                    hashMap.Add(nums[i], new List<int>() { i });
                else
                    hashMap[nums[i]].Add(i);
            }

            var indices = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var rest = target - nums[i];
                if (!hashMap.ContainsKey(rest))
                    continue;

                if (rest == nums[i])
                {
                    var restIndex = hashMap[rest].Where(x => x != i);
                    if (!restIndex.Any())
                        continue;

                    indices.Add(i);
                    indices.Add(restIndex.ElementAt(0));
                }
                else
                {
                    indices.Add(i);
                    var restIndex = hashMap[rest].ElementAt(0);
                    indices.Add(restIndex);
                }

                break;
            }

            return indices.ToArray();
        }
    }
}
