using System.Collections.Generic;
using System.Linq;

namespace CloneGraph
{
    public class Clone
    {
        public static Node CloneGraph(Node node)
        {
            if (node == null)
                return null;

            var visitedNodes = new Dictionary<int, Node> { { node.val, new Node(node.val) } };

            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var currentNode = queue.Dequeue();
                foreach (var neighbor in currentNode.neighbors)
                {
                    // add non-existing nodes to hashmap
                    if (!visitedNodes.ContainsKey(neighbor.val))
                    {
                        visitedNodes.Add(neighbor.val, new Node(neighbor.val));
                        queue.Enqueue(neighbor);
                    }

                    // update the references of current node's neighbors
                    visitedNodes[currentNode.val].neighbors.Add(visitedNodes[neighbor.val]);
                }
            }

            return visitedNodes[node.val];
        }

        public static bool AreEqual(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            if (first != null && second == null)
                return false;

            if (first == null && second != null)
                return false;

            if (first.val != second.val)
                return false;

            var firstQueue = new Queue<Node>();
            firstQueue.Enqueue(first);

            var secondQueue = new Queue<Node>();
            secondQueue.Enqueue(second);

            while (firstQueue.Any() && secondQueue.Any())
            {
                var currentFirst = firstQueue.Dequeue();
                var currentSecond = secondQueue.Dequeue();

                if (currentSecond.val != currentFirst.val)
                    return false;

                foreach (var neighbor in currentFirst.neighbors)
                    firstQueue.Enqueue(neighbor);

                foreach (var neighbor in currentSecond.neighbors)
                    secondQueue.Enqueue(neighbor);
            }

            return !firstQueue.Any() && !secondQueue.Any();
        }
    }
}
