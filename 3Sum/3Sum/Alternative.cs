using System.Collections.Generic;
using System.Linq;

namespace _3Sum
{
    public class Alternative
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return new List<IList<int>>();
            }

             nums = nums.OrderBy(x => x).ToArray();

            var threeSum = new HashSet<Combination>();
            for (var i = 0; i < nums.Length; i++)
            {
                var target = nums[i] * (-1);
                var twoSum = TwoSum(nums, target, i+1).OrderBy(x => x).ToList();
                if(!twoSum.Any())
                    continue;

                var sums = new Combination()
                {
                    First = nums[i],
                    Second = twoSum[0],
                    Third = twoSum[1]
                };
               
                if(threeSum.Contains(sums))
                    continue;

                threeSum.Add(sums);
            }

            return CombinationsToList(threeSum);
        }

        private static List<IList<int>> CombinationsToList(IEnumerable<Combination> combinationSet)
        {
            var combinationsList = new List<IList<int>>();

            foreach (var combination in combinationSet)
            {
                var combinationList = new List<int> { combination.First, combination.Second, combination.Third };
                combinationsList.Add(combinationList);
            }

            return combinationsList;
        }
        private static IEnumerable<int> TwoSum(IReadOnlyList<int> nums, int target, int startIndex)
        {
            var elementAtIndex = FindElementIndices(nums);

            var twoSum = new List<int>();
            for (var i = startIndex; i < nums.Count; i++)
            {
                var searchFor = target - nums[i];
                if (!elementAtIndex.ContainsKey(searchFor))
                    continue;

                var searchIndices = elementAtIndex[searchFor].Where(x => x != i && x != startIndex -1).ToList();
                if (!searchIndices.Any())
                    continue;

                twoSum.Add(nums[i]);
                twoSum.Add(searchFor);
                break;
            }

            return twoSum;
        }

        private static Dictionary<int, List<int>> FindElementIndices(IReadOnlyList<int> nums)
        {
            var elementAtIndex = new Dictionary<int, List<int>>();
            for (var i = 0; i < nums.Count; i++)
            {
                if (elementAtIndex.ContainsKey(nums[i]))
                    elementAtIndex[nums[i]].Add(i);
                else
                    elementAtIndex.Add(nums[i], new List<int> {i});
            }

            return elementAtIndex;
        }
    }
}
