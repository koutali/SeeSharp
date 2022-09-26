using System.Linq;

namespace DecodeWays
{
    public class Decoding
    {
        public static int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s) || s.StartsWith('0') || s.Length == 0)
                return 0;

            var dp = new int [s.Length + 1];
            // empty string
            dp[0] = 1;

            // one char
            dp[1] = s.ElementAt(0) == '0' ? 0 : 1;
            
            for (var i = 2; i < dp.Length; i++)
            {
                var oneDigit = ConvertToInt(s.Substring(i - 1, 1));

                if (oneDigit >= 1)
                {
                    dp[i] += dp[i - 1];
                }

                var twoDigits = ConvertToInt(s.Substring(i - 2, 2));
                if (twoDigits >= 10 && twoDigits <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp.Last();
        }

        private static int ConvertToInt(string s)
        {
            var ok = int.TryParse(s, out var num);
            return !ok ? 0 : num;
        }
    }
}
