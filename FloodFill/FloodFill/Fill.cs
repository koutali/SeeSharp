namespace FloodFill
{
    public class Fill
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var visited = new bool[image.Length][];
            for (int i = 0; i < image.Length; i++)
            {
                visited[i] = new bool[image[i].Length];
            }

            var currentColor = image[sr][sc];   

            Dfs(sr, sc, image, visited, currentColor, newColor);          
            return image;
        }

        private static void Dfs(int x, int y, int[][] image, bool[][] visited, int currentColor, int newColor)
        {
            if (x < 0 || x >= image.Length)
            {
                return;
            }

            if (y < 0 || y >= image[x].Length)
            {
                return;
            }

            if (image[x][y] != currentColor || visited[x][y])
            {
                return;
            }

            visited[x][y] = true;
            image[x][y] = newColor;

            Dfs(x - 1, y, image, visited, currentColor, newColor);
            Dfs(x + 1, y, image, visited, currentColor, newColor);

            Dfs(x, y - 1, image, visited, currentColor, newColor);
            Dfs(x, y + 1, image, visited, currentColor, newColor);
        }
    }
}