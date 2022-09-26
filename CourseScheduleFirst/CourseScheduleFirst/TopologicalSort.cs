namespace CourseScheduleFirst
{
    public class TopologicalSort
    {
        public static int[] FindOrder(int numCourses, int[][] dependencies)
        {
            var order = new HashSet<int>();

            var preMap = GenerateMap(numCourses, dependencies);
            var visited = new HashSet<int>();

            for (var currentCourse = 0; currentCourse < numCourses; currentCourse++)
            {
                if (visited.Contains(currentCourse)) continue;
                var cycleDetected = TopologicalSortAndCycleCheck(currentCourse, preMap, visited, order);
                if (cycleDetected)
                    return new List<int>().ToArray();
            }

            return order.Reverse().ToArray();
        }

        private static bool TopologicalSortAndCycleCheck(int currentNode,
            Dictionary<int, List<int>> adjacencyList,
            HashSet<int> currentlyVisiting,
            HashSet<int> order)
        {
            // no dependency on anything, thus no cycle
            if (!adjacencyList.ContainsKey(currentNode))
            {
                order.Add(currentNode);
                return false;
            }

            // cycle
            if (currentlyVisiting.Contains(currentNode))
                return true;

            currentlyVisiting.Add(currentNode);
            var neighbours = adjacencyList[currentNode];

            foreach (var neighbor in neighbours)
            {
                var cycleDetected = TopologicalSortAndCycleCheck(neighbor, 
                    adjacencyList, 
                    currentlyVisiting, 
                    order);

                if (cycleDetected)
                {
                    return true;
                }
            }

            currentlyVisiting.Remove(currentNode);
            order.Add(currentNode);
            return false;
        }

        private static Dictionary<int, List<int>> GenerateMap(int numCourses, int[][] dependencies)
        {
            var preMap = new Dictionary<int, List<int>>();
            foreach (var dependency in dependencies)
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
