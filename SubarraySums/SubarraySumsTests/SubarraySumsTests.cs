using Xunit;

namespace SubarraySumsNamespace
{
    public class SubarraySumsTests
    {
        [Fact]
        public void Test_check_if_k_is_met()
        {
            var input = new[] {23, 2, 6, 4, 7};
            const int k = 6;
            Assert.True(SubarraySums.CheckSubarraySum(input, k));
        }

        [Fact]
        public void Test_number_of_matches()
        {
            var input = new[] { 1,1,1 };
            const int k = 2;
            const int expected = 2;
            Assert.Equal(expected, SubarraySums.SubarraySum(input, k));
        }

        [Fact]
        public void Test_number_of_matches_2()
        {
            var input = new[] { 1, 2, 3 };
            const int k = 3;
            const int expected = 2;
            Assert.Equal(expected, SubarraySums.SubarraySum(input, k));
        }
    }
}
