namespace WordSearchTests
{
    public class WordSearchTests
    {
        [Fact]
        public void Test1()
        {
            const string word = "ABCCED";
            char[][] board = {
                new[] { 'A', 'B', 'C', 'E' },
                new[] { 'S', 'F', 'C', 'S' },
                new[] { 'A', 'D', 'E', 'E' },
            };

            var wordSearch = new WordSearch.WordSearch();
            var found = wordSearch.Exist(board, word);
            Assert.True(found);
        }

        [Fact]
        public void Test2()
        {
            const string word = "ABCB";
            char[][] board = {
                new[] { 'A', 'B', 'C', 'E' },
                new[] { 'S', 'F', 'C', 'S' },
                new[] { 'A', 'D', 'E', 'E' },
            };

            var wordSearch = new WordSearch.WordSearch();
            var found = wordSearch.Exist(board, word);
            Assert.False(found);
        }
    }
}