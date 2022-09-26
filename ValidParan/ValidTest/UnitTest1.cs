using ValidParan;
using Xunit;

namespace ValidTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const string s = "()";
            Assert.True(Valid.IsValid(s));
        }
    }
}
