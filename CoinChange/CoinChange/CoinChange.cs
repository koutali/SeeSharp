using System.Collections.Generic;

namespace CoinChange
{
    public class CoinChangeClass
    {
        public static int CoinChange(int[] coins, int amount)
        {
            if (amount < 1)
                return 0;

            return CoinChange(coins, amount, new int[amount]);
        }

        private static int CoinChange(IEnumerable<int> coins, int rem, IList<int> count)
        {
            if (rem < 0)
                return -1;

            if (rem == 0)
                return 0;

            if (count[rem - 1] != 0)
                return count[rem - 1];

            var min = int.MaxValue;

            foreach (var coin in coins)
            {
                var res = CoinChange(coins, rem - coin, count);

                if (res >= 0 && res < min)
                    min = 1 + res;
            }

            count[rem - 1] = (min == int.MaxValue) ? -1 : min;
            return count[rem - 1];
        }
    }
}
