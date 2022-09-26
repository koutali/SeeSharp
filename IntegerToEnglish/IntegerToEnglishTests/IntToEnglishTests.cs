using System;
using IntegerToEnglish;
using Xunit;

namespace IntegerToEnglishTests
{
    public class IntToEnglishTests
    {
        [Fact]
        public void Zero()
        {
            const string expected = "Zero";
            var returned = IntToEnglish.NumberToWords(0);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void One_digit()
        {
            const string expected = "Four";
            var returned = IntToEnglish.NumberToWords(4);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digits()
        {
            const string expected = "Twenty Four";
            var returned = IntToEnglish.NumberToWords(24);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digit_20()
        {
            const string expected = "Twenty";
            var returned = IntToEnglish.NumberToWords(20);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digits_12()
        {
            const string expected = "Twelve";
            var returned = IntToEnglish.NumberToWords(12);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digits_11()
        {
            const string expected = "Eleven";
            var returned = IntToEnglish.NumberToWords(11);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Two_digits_16()
        {
            const string expected = "Sixteen";
            var returned = IntToEnglish.NumberToWords(16);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Three_digits()
        {
            const string expected = "One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Three_digits_100()
        {
            const string expected = "One Hundred";
            var returned = IntToEnglish.NumberToWords(100);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Three_digits_410()
        {
            const string expected = "Four Hundred Ten";
            var returned = IntToEnglish.NumberToWords(410);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Four_digits()
        {
            const string expected = "Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(2124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Four_digits_1000()
        {
            const string expected = "One Thousand";
            var returned = IntToEnglish.NumberToWords(1000);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Five_digits()
        {
            const string expected = "Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(52124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Six_digits()
        {
            const string expected = "Seven Hundred Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(752124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Seven_digits()
        {
            const string expected = "Five Million Seven Hundred Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(5752124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Seven_digits_2()
        {
            const string expected = "One Million Ten";
            var returned = IntToEnglish.NumberToWords(1000010);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Eight_digits()
        {
            const string expected = "Fifteen Million Seven Hundred Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(15752124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Nine_digits()
        {
            const string expected = "Eight Hundred Fifteen Million Seven Hundred Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(815752124);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Ten_digits()
        {
            const string expected = "One Billion Eight Hundred Fifteen Million Seven Hundred Fifty Two Thousand One Hundred Twenty Four";
            var returned = IntToEnglish.NumberToWords(1815752124);
            Assert.Equal(expected, returned);
        }
    }
}
