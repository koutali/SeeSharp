using ReorderLogFiles;
using Xunit;

namespace ReorderedLogFilesTests
{
    public class ReorderTests
    {
        [Fact]
        public void Test1()
        {
            var logs = new [] {"a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"};
            var expected = new [] { "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };
            var returned = Reorder.ReorderLogFiles(logs);

            Assert.Equal(expected.Length, returned.Length);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], returned[i]);
            }
        }

        [Fact]
        public void Test2()
        {
            var logs = new[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            var expected = new[] { "let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6" };
            var returned = Reorder.ReorderLogFiles(logs);

            Assert.Equal(expected, returned);
        }
    }
}
