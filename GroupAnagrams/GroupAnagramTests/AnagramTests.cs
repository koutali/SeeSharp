using System.Collections.Generic;
using System.Linq;
using GroupAnagrams;
using Xunit;
using Enumerable = System.Linq.Enumerable;

namespace GroupAnagramTests
{
    public class AnagramTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new List<IList<string>>
            {
                new List<string> { "bat" },
                new List<string> { "nat", "tan" },
                new List<string> { "ate", "eat", "tea" }
            };

            var returned = Anagrams.GroupAnagrams(input);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var t in returned)
            {
                Assert.Contains(t, expected);
            }
        }

        [Fact]
        public void Test2()
        {
            var input = new[] { "" };
            var expected = new List<IList<string>>
            {
                new List<string> { "" }
            };

            var returned = Anagrams.GroupAnagrams(input);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var t in returned)
            {
                Assert.Contains(t, expected);
            }
        }

        [Fact]
        public void Test3()
        {
            var input = new[] { "a" };
            var expected = new List<IList<string>>
            {
                new List<string> { "a" }
            };

            var returned = Anagrams.GroupAnagrams(input);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var t in returned)
            {
                Assert.Contains(t, expected);
            }
        }

        [Fact]
        public void Test4()
        {
            var input = new[] { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" };

            var expected = new List<IList<string>>
            {
                new List<string> { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" },
                new List<string> { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" }
            };

            var returned = Anagrams.GroupAnagrams(input);

            Assert.Equal(expected.Count, returned.Count);
            foreach (var t in returned)
            {
                Assert.Contains(t, expected);
            }
        }
    }
}
