using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RepeatedSubstring
{
    public class RepeatedSubstring
    {
        public static bool RepeatedSubstringPattern(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException(nameof(s));

            var divisors = GetDivisors(s.Length);
            if (divisors.Count == 0)
            {
                return false;
            }

            var results = new List<bool>();
            foreach (var windowLength in divisors)
            {
                var first = s.Substring(0, windowLength);
                for (var i = windowLength; i <= s.Length - windowLength; i += windowLength)
                {
                    var second = s.Substring(i, windowLength);
                    if (!first.Equals(second))
                    {
                        break;
                    }
                    results.Add(first.Equals(second));
                }
            }

            return results.Contains(true);
        }

        private static IList<int> GetDivisors(int n)
        {
            var divisors = new List<int>();
            for (var i = n/2; i > 0; i--)
            {
                if((n % i) == 0)
                    divisors.Add(i);
            }

            return divisors;
        }
    }
}
