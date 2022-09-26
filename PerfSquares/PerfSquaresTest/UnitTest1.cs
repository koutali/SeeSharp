using System;
using PerfSquares;
using Xunit;

namespace PerfSquaresTest
{
    public class UnitTest1
    {
        [Fact]
        public void Input_12()
        {
            const int n = 12;
            const int expected = 3;

            var squares = new Squares();
            var returned = squares.NumSquares(n);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Input_13()
        {
            const int n = 13;
            const int expected = 2;

            var squares = new Squares();
            var returned = squares.NumSquares(n);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Input_1()
        {
            const int n = 1;
            const int expected = 1;

            var squares = new Squares();
            var returned = squares.NumSquares(n);
            Assert.Equal(expected, returned);
        }
    }
}
