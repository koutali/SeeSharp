namespace CourseScheduleFirst
{
    public class CycleDetection
    {
        public static bool CanFinish(int numCourses, int[][] dependencies)
        {
            var preMap = GenerateMap(numCourses, dependencies);
            var visited = new HashSet<int>();

            for (var i = 0; i < numCourses; i++)
            {
                if(!visited.Contains(i))
                {
                   var cycleDetected = CycleDetected(i, preMap, visited);
                    if (cycleDetected)
                        return false;
                }
            }

            return true;
        }

        private static bool CycleDetected(int currentNode, 
            Dictionary<int, List<int>> adjacencyList, 
            HashSet<int> currentlyVisiting)
        {
            // no dependency on anything, thus no cycle
            if (!adjacencyList.ContainsKey(currentNode))
                return false;

            // cycle
            if (currentlyVisiting.Contains(currentNode))
                return true;

            currentlyVisiting.Add(currentNode);
            var neighbours = adjacencyList[currentNode];

            foreach (var neighbor in neighbours)
            {
                var cycleDetected = CycleDetected(neighbor, adjacencyList, currentlyVisiting);
                if (cycleDetected)
                {
                    return true;
                }
            }

            currentlyVisiting.Remove(currentNode);
            return false;
        }

        private static Dictionary<int, List<int>> GenerateMap(int numCourses, int[][] dependencies)
        {
            var preMap = new Dictionary<int, List<int>>();
            foreach(var dependency in dependencies)
            {
                if (dependency == null)
                    break;

                var from = dependency[1];
                var to = dependency[0];

                if (preMap.ContainsKey(from))
                {
                    preMap[from].Add(to);
                }
                else
                {
                    preMap.Add(from, new List<int>() { to });
                }                
            }

            return preMap;
        }
    }
}