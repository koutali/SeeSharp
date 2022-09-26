namespace WordSearch
{
    public class WordSearch
    {
        private bool[,] visited;

        public bool Exist(char[][] board, string word)
        {
            visited = new bool[board.Length, board[0].Length];
            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (Dfs(i, j, 0, word, board))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Dfs(int row, int col, int index, string word, char[][]board)
        {
            if (index == word.Length)
            {
                return true;
            }

            var colLength = board[0].Length;
            var rowLength = board.Length;
            if (row < 0 || col < 0 || row >= rowLength || col >= colLength || word[index] != board[row][col])
            {
                return false;
            }
            
            visited[row, col] = true;
            var result = Dfs(row + 1, col, index + 1, word, board) ||
                         Dfs(row - 1, col, index + 1, word, board) ||
                         Dfs(row, col + 1, index + 1, word, board) ||
                         Dfs(row, col - 1, index + 1, word, board);

            visited[row, col] = false;
            return result;
        }
    }
}