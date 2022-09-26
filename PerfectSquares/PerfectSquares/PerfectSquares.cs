using System;
using System.Collections.Generic;

namespace PerfectSquares
{
    public class PerfectSquares
    {
        private static readonly Dictionary<int, int> dict = new();

        public static int NumSquares(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException(nameof(n));
            }

            if (dict.ContainsKey(n))
            {
                return dict[n];
            }

            var smallRoot = (int) Math.Floor(Math.Sqrt(n));
            if (smallRoot * smallRoot == n)
            {
                dict[n] = 1;
                return 1;
            }

            var min = int.MaxValue;
            for (var i = smallRoot; i >= 1; i--)
            {
                var num = 1 + NumSquares(n - i * i);
                if (num < min)
                {
                    min = num;
                }
            }

            dict[n] = min;
            return min;
        }

    }
}
