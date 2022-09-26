using System.Collections.Generic;
using WordLadder;
using Xunit;

namespace WordLadderTests
{
    public class LadderTests
    {
        [Fact]
        public void DirectPathAvailable()
        {
            const string beginWord = "hit";
            const string endWord = "cog";
            var list = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };

            var ladder = new Ladder();
            var returned = ladder.LadderLength(beginWord, endWord, list);

            Assert.Equal(5, returned);
        }

        [Fact]
        public void NoPathAvailable()
        {
            const string beginWord = "hit";
            const string endWord = "cog";
            var list = new List<string> { "hot", "dot", "dog", "lot", "log" };

            var ladder = new Ladder();
            var returned = ladder.LadderLength(beginWord, endWord, list);

            Assert.Equal(0, returned);
        }

        [Fact]
        public void NoPathAvailable2()
        {
            const string beginWord = "hot";
            const string endWord = "dog";
            var list = new List<string> { "hot", "dog" };

            var ladder = new Ladder();
            var returned = ladder.LadderLength(beginWord, endWord, list);

            Assert.Equal(0, returned);
        }
    }
}
