using DecodeWays;
using Xunit;

namespace DecodeWaysTests
{
    public class DecodingTests
    {
        [Fact]
        public void Test_12()
        {
            const string input = "12";
            const int expected = 2;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test_2101()
        {
            const string input = "2101";
            const int expected = 1;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test_21201234()
        {
            const string input = "1201234";
            const int expected = 3;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test_all_ones()
        {
            const string input = "111111111111111111111111111111111111111111111";
            const int expected = 1134903170;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test_226()
        {
            const string input = "226";
            const int expected = 3;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }
        [Fact]
        public void Test_0()
        {
            const string input = "0";
            const int expected = 0;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }
        [Fact]
        public void Test_06()
        {
            const string input = "06";
            const int expected = 0;
            var returned = Decoding.NumDecodings(input);

            Assert.Equal(expected, returned);
        }
    }
}
