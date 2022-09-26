using PlusOne;
using Xunit;

namespace PlusOneTests
{
    public class AddOneTests
    {
        [Fact]
        public void Test1()
        {
            var digits = new[] { 9 };
            var expected = new[] { 1, 0 };
            var returned = AddOne.PlusOne(digits);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            var digits = new[] { 1, 2, 3 };
            var expected = new[] { 1, 2, 4 };
            var returned = AddOne.PlusOne(digits);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            var digits = new[] { 9, 9 };
            var expected = new[] { 1, 0, 0 };
            var returned = AddOne.PlusOne(digits);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            var digits = new[] { 9, 9, 9, 9 };
            var expected = new[] { 1, 0, 0, 0, 0 };
            var returned = AddOne.PlusOne(digits);
            Assert.Equal(expected, returned);
        }
    }
}
