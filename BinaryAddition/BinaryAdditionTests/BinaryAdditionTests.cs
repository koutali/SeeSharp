using System;
using Xunit;

namespace BinaryAdditionTests
{
    public class BinaryAdditionTests
    {
        [Fact]
        public void ALonger()
        {
            const string a = "11";
            const string b = "1";

            const string expected = "100";
            var returned = BinaryAddition.BinaryAddition.AddBinary(a, b);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Both_same_length()
        {
            const string a = "1010";
            const string b = "1011";

            const string expected = "10101";
            var returned = BinaryAddition.BinaryAddition.AddBinary(a, b);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void BLonger()
        {
            const string a = "1";
            const string b = "11";

            const string expected = "100";
            var returned = BinaryAddition.BinaryAddition.AddBinary(a, b);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Failed_1()
        {
            const string a = "110010";
            const string b = "10111";

            const string expected = "1001001";
            var returned = BinaryAddition.BinaryAddition.AddBinary(a, b);

            Assert.Equal(expected, returned);
        }
    }
}
