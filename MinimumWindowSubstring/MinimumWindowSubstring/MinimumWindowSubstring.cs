using System.Collections.Generic;
using System.Linq;

namespace MinimumWindowSubstring
{
    public class MinimumWindowSubstring
    {
        public static string MinWindow(string s, string t)
        {
            var length = int.MaxValue;
            var minLeft = 0;

            var right = 0;
            for (var left = 0; left < s.Length; left++)
            {
                var tIndex = 0;
                var matches = 0;
                var allFound = false;
                for (; right < s.Length && tIndex < t.Length; right++)
                {
                    var ch = t[tIndex];
                    if (ch != s[right]) 
                        continue;

                    if (tIndex == 0)
                        left = right;

                    tIndex++;
                    matches++;

                    if (matches != t.Length) 
                        continue;

                    allFound = true;
                    break;
                }

                if (!allFound)
                    return string.Empty;

                if (right - left < length)
                {
                    length = right - left + 1;
                    minLeft = left;
                }

                left = right;
            }

            return s.Substring(minLeft, length);
		}
    }
}
