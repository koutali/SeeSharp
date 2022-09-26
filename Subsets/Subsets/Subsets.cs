using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subsets
{
    public class SubsetsNamespace
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentException(nameof(nums));
            }

            var output = new List<IList<int>>();
            var limit = (int) Math.Pow(2, nums.Length);

            for (var i = 0; i <limit; ++i)
            {
                // generate bitmask, from 0..00 to 1..11
                var bitmask = ToBinaryString(i, nums.Length);

                // append subset corresponding to that bitmask
                var current = new List<int>();
                for (var j = 0; j < nums.Length; ++j)
                {
                    if (bitmask.ElementAt(j) == '1') 
                        current.Add(nums[j]);
                }
                output.Add(current);
            }
            
            return output;
        }

        private static string ToBinaryString(int num, int length)
        {
            var sb = new StringBuilder();

            while (num > 0)
            {
                var rem = num % 2;
                sb.Append(rem);
                num /= 2;
            }

            var sbLength = sb.Length;
            while (sbLength < length)
            {
                sb.Append(0);
                sbLength++;
            }

            //var s = new string(sb.ToString().Reverse().ToArray());
            return sb.ToString();
        }
    }
}
