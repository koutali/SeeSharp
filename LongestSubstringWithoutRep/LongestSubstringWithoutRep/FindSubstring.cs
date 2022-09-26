using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRep
{
    public class FindSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;

            var start = 0;
            var end = 1;

            var lengths = new List<int>();
            var set = new HashSet<char> {s[start]};

            while (start < s.Length && end < s.Length)
            {
                if (!set.Contains(s[end]))
                {
                    set.Add(s[end]);
                    end++;
                }
                else
                {
                    lengths.Add(set.Count);
                    set.Clear();
                    start++;
                    end = start;
                }
            }

            lengths.Add(set.Count);
            return lengths.Max();
        }
    }
}
