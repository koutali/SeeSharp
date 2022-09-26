using System;
using Xunit;

namespace PerfectSquaresTests
{
    public class PerfectSquaresTests
    {
        [Fact]
        public void Negative_number_throws_exception()
        {
            Assert.Throws<ArgumentException>(() => PerfectSquares.PerfectSquares.NumSquares(-1));
        }

        [Fact]
        public void Zero_throws_exception()
        {
            Assert.Throws<ArgumentException>(() => PerfectSquares.PerfectSquares.NumSquares(0));
        }

        [Fact]
        public void Valid_input1()
        {
            const int input = 12;
            const int expected = 3;

            var returned = PerfectSquares.PerfectSquares.NumSquares(input);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Valid_input2()
        {
            const int input = 13;
            const int expected = 2;

            var returned = PerfectSquares.PerfectSquares.NumSquares(input);
            Assert.Equal(expected, returned);
        }
        [Fact]
        public void Valid_input3()
        {
            const int input = 4;
            const int expected = 1;

            var returned = PerfectSquares.PerfectSquares.NumSquares(input);
            Assert.Equal(expected, returned);
        }
    }
}
