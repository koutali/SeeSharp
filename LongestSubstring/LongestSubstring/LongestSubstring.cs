using System.Collections.Generic;
using System.Linq;

namespace LongestSubstring
{
    public class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var lengths = new List<int>();
            var left = 0;
            var right = 1;

            for (; right < s.Length; right++)
            {
                if (s[left] == s[right])
                {
                    lengths.Add(right-left);
                    left++;
                }
            }
            return lengths.Any() ? lengths.Max() : 0;
        }
    }
}
