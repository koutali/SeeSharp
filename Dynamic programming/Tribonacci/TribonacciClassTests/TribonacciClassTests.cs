using Tribonacci;
using Xunit;

namespace TribonacciClassTests
{
    public class TribonacciClassTests
    {
        [Fact]
        public void Test1()
        {
            int result = TribonacciClass.Tribonacci(25);
            Assert.Equal(1389537, result);
        }
    }
}