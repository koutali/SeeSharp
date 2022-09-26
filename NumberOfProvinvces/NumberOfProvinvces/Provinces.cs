using System;
using System.Collections.Generic;

namespace NumberOfProvinvces
{
    public class Provinces
    {
        public static int FindCircleNum(int[][] isConnected)
        {
            var visited = new bool[isConnected.Length];

            var disconnectedComponents = 0;
            for (var startNodeIndex = 0; startNodeIndex < isConnected.Length; startNodeIndex++)
            {
                if (visited[startNodeIndex])
                    continue;

                Dfs(startNodeIndex, isConnected, visited);
                disconnectedComponents++;
            }

            return disconnectedComponents;
        }

        private static void Dfs(int startNodeIndex, int[][] adjacencyMatrix, bool[] visited)
        {
            visited[startNodeIndex] = true;

            for (var i = 0; i < adjacencyMatrix[startNodeIndex].Length; i++)
            {
                if (adjacencyMatrix[startNodeIndex][i] == 0)
                {
                    continue;
                }

                if (!visited[i])
                {
                    Dfs(i, adjacencyMatrix, visited);
                }
            }
        }
    }
}
