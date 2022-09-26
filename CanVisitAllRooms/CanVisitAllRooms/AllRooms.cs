using System.Collections.Generic;

namespace CanVisitAllRooms
{
    public class AllRooms
    {
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count];
            var disconnectedComponents = 0;
            for (var startNodeIndex = 0; startNodeIndex < rooms.Count; startNodeIndex++)
            {
                if (visited[startNodeIndex]) 
                    continue;

                Dfs(startNodeIndex, rooms, visited);
                disconnectedComponents++;
            }

            return disconnectedComponents == 1;
        }

        private static void Dfs(int startNodeIndex, IList<IList<int>> adjacencyList, bool[] visited)
        {
            visited[startNodeIndex] = true;

            foreach (var neighbor in adjacencyList[startNodeIndex])
            {
                if (!visited[neighbor])
                {
                    Dfs(neighbor, adjacencyList, visited);
                }
            }
        }
    }
}
