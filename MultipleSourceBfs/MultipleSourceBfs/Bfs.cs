namespace MultipleSourceBfs
{
    public class MultipleBfs
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            // initialize distances matrix
            var distance = new int[mat.Length][];
            for (var i = 0; i < mat.Length; i++)
            {
                distance[i] = new int[mat[i].Length];
                for (var j = 0; j < distance[i].Length; j++)
                {
                    distance[i][j] = int.MaxValue;
                }
            }

            Bfs(mat, distance);
            return distance;
        }

        private static void Bfs(int[][] mat, int[][] distance)
        {
            var q = new Queue<KeyValuePair<int, int>>();

            // enqueue all zeros
            for (var i = 0; i < mat.Length; i++)
            {
                for (var j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        distance[i][j] = 0;
                        var coordinates = new KeyValuePair<int, int>(i, j);
                        q.Enqueue(coordinates);
                    }
                }
            }

            // process the queue to find matrices
            while (q.Any())
            {
                var current = q.Dequeue();

                var x = current.Key;
                var y = current.Value;


                if (x - 1 >= 0 && distance[x - 1][y] == int.MaxValue)
                {
                    distance[x - 1][y] = distance[current.Key][current.Value] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(x - 1, y));
                }

                if (x + 1 < mat.Length && distance[x + 1][y] == int.MaxValue)
                {
                    distance[x + 1][y] = distance[current.Key][current.Value] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(x + 1, y));
                }

                if (y - 1 >= 0 && distance[x][y - 1] == int.MaxValue)
                {
                    distance[x][y - 1] = distance[current.Key][current.Value] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(x, y - 1));
                }

                if (y + 1 < mat[x].Length && distance[x][y + 1] == int.MaxValue)
                {
                    distance[x][y + 1] = distance[current.Key][current.Value] + 1;
                    q.Enqueue(new KeyValuePair<int, int>(x, y + 1));
                }
            }
        }
    }
}