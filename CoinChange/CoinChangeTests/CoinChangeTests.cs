using CoinChange;
using Xunit;

namespace CoinChangeTests
{
    public class CoinChangeTests
    {
        [Fact]
        public void Amount_3_No_Change_Possible()
        {
            var coins = new int[] {2};
            var returned = CoinChangeClass.CoinChange(coins, 3);
            Assert.Equal(-1, returned);
        }

        [Fact]
        public void Amount_11()
        {
            var coins = new int[] { 1,2,5 };
            var returned = CoinChangeClass.CoinChange(coins, 11);
            Assert.Equal(3, returned);
        }

        [Fact]
        public void Amount_Zero()
        {
            var coins = new int[] { 1};
            var returned = CoinChangeClass.CoinChange(coins, 0);
            Assert.Equal(0, returned);
        }

        [Fact]
        public void Amount_2()
        {
            var coins = new int[] { 1 };
            var returned = CoinChangeClass.CoinChange(coins, 2);
            Assert.Equal(2, returned);
        }
    }
}
