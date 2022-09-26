using ExpressiveWords;
using Xunit;

namespace ExpressiveWordsTests
{
    public class ExpressiveTests
    {
        [Fact]
        public void Test1()
        {
            const string s = "heeellooo";
            var words = new[] { "helo", "hi", "hello" };
            const int expected = 1;
            var returned = Expressive.ExpressiveWords(s, words);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test2()
        {
            const string s = "sass";
            var words = new[] { "sa"};
            const int expected = 0;
            var returned = Expressive.ExpressiveWords(s, words);
            Assert.Equal(expected, returned);
        }

        [Fact]
        public void Test3()
        {
            const string s = "dddiiiinnssssssoooo";
            var words = new[] { "dinnssoo","ddinso","ddiinnso","ddiinnssoo","ddiinso","dinsoo","ddiinsso","dinssoo","dinso"};
            const int expected = 3;
            var returned = Expressive.ExpressiveWords(s, words);
            Assert.Equal(expected, returned);
        }
    }
}
