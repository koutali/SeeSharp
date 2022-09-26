using MyAtoiNamespace;
using Xunit;

namespace MyAtoiTests
{
    public class MyAtoiTests
    {
        [Fact]
        public void JustNumber()
        {
            const string s = "42";
            const int expected = 42;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void NumberWithSpaceAndSign()
        {
            const string s = "            -42";
            const int expected = -42;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void NumberWithChars()
        {
            const string s = "4193 with words";
            const int expected = 4193;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void NumberStartingWithChars()
        {
            const string s = "words with 4192";
            const int expected = 0;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void RangeCorrection()
        {
            const string s = "-91283472332";
            const int expected = -2147483648;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void FloatingPoint()
        {
            const string s = "3.14159";
            const int expected = 3;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void WeirdFloatingPoint() 
        { 
            const string s = "00000 - 42a1234";
            const int expected = 0;
            var returned = MyAtoiClass.MyAtoi(s);
            Assert.Equal(expected, returned);
        }

    }
}
