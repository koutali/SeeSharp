using Xunit;

namespace IntegerToRomanTest
{
    public class IntegerToRomanTests
    {
        [Fact]
        public void Test1()
        {
            const int number = 3;
            const string expected = "III";
            var returned = IntegerToRoman.IntegerToRoman.IntToRoman(number);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const int number = 4;
            const string expected = "IV";
            var returned = IntegerToRoman.IntegerToRoman.IntToRoman(number);
            Assert.Equal(expected, returned);
        }


        [Fact]
        public void Test3()
        {
            const int number = 9;
            const string expected = "IX";
            var returned = IntegerToRoman.IntegerToRoman.IntToRoman(number);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test4()
        {
            const int number = 58;
            const string expected = "LVIII";
            var returned = IntegerToRoman.IntegerToRoman.IntToRoman(number);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test5()
        {
            const int number = 1994;
            const string expected = "MCMXCIV";
            var returned = IntegerToRoman.IntegerToRoman.IntToRoman(number);
            Assert.Equal(expected, returned);
        }
    }
}
