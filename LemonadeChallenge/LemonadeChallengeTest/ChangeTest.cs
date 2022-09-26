using LemonadeChallenge;
using Xunit;

namespace LemonadeChallengeTest
{
    public class ChangeTest
    {
        [Fact]
        public void Test1()
        {
            var bills = new[] { 5, 5, 5, 10, 20 };
            Assert.True(Change.LemonadeChange(bills));
        }

        [Fact]
        public void Test2()
        {
            var bills = new[]
            {
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 20, 5, 5,
                5, 5, 5, 5, 5, 10, 5, 20, 20, 5, 5, 5, 5, 5, 10, 5,
                5, 5, 20, 5, 5, 5, 10, 5, 5, 10, 5, 20, 5, 5, 20, 5,
                10, 5, 5, 20, 5, 5, 5, 5, 5, 5, 10, 20, 5, 20, 20, 10,
                5, 20, 20, 5, 10, 5, 5, 5, 5, 5, 5, 20, 20, 20, 20, 5,
                5, 10, 5, 20, 5, 5, 5, 5, 10, 10, 5, 5, 5, 20, 5, 5, 5,
                5, 5, 5, 20, 5, 20, 10, 10, 20, 5, 5, 5, 5, 20, 20, 5, 5, 
                5, 5, 20, 5, 20, 20 };

            Assert.True(Change.LemonadeChange(bills));
        }
    }
}
