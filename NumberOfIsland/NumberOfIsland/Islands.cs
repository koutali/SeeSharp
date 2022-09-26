namespace NumberOfIsland
{
    public class Islands
    {
        public static int NumIslands(char[][] grid)
        {
            var visited = new bool[grid.Length][];
            for (var i = 0; i < grid.Length; i++)
            {
                visited[i] = new bool [grid[i].Length];
            }

            var islands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (visited[i][j] || grid[i][j] != '1') 
                        continue;

                    Dfs(i, j, grid, visited);
                    islands++;
                }
            }

            return islands;
        }

        private static void Dfs(int startI, int startJ, char[][] grid, bool[][] visited)
        {
            if (startI < 0 || startI >= grid.Length)
            {
                return;
            }

            if (startJ < 0 || startJ >= grid[startI].Length)
            {
                return;
            }

            if (grid[startI][startJ] == '0' || visited[startI][startJ])
            {
                return;
            }

            visited[startI][startJ] = true;

            Dfs(startI - 1, startJ, grid, visited);
            Dfs(startI + 1, startJ, grid, visited);

            Dfs(startI, startJ  - 1, grid, visited);
            Dfs(startI, startJ + 1, grid, visited);
        }
    }
}
