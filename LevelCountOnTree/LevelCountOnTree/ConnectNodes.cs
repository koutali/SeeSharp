using System;
using System.Collections.Generic;
using System.Linq;

namespace LevelCountOnTree
{
    public class ConnectNodes
    {
        public static Node Connect(Node root)
        {
            if (root == null)
                return null;

            ConnectInternal(root);
            return root;
        }

        private static void ConnectInternal(Node node)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            var nodeCountOnLevel = 0;
            var levelCount = 0;

            while (queue.Any())
            {
                node = queue.Dequeue();
                Console.WriteLine("node val: {0}", node.val);
                Console.WriteLine("nodeCountOnLevel: {0}", nodeCountOnLevel);
                Console.WriteLine("levelCount: {0}", levelCount);

                if (queue.Any())
                {
                    if (IsNodeAtEndOfLevel(nodeCountOnLevel, levelCount))
                    {
                        Console.WriteLine("node count is a power of two, assigning null to next");
                        node.next = null;
                        nodeCountOnLevel = 0;
                        levelCount++;
                    }
                    else
                    {
                        Console.WriteLine("assigning queue peek: {0}", queue.Peek().val);
                        node.next = queue.Peek();
                    }
                }
                else
                {
                    Console.WriteLine("queue empty, assigning null to next");
                    node.next = null;
                    nodeCountOnLevel = 0;
                    levelCount++;
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    Console.WriteLine("enqueued left: {0}", node.left.val);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    Console.WriteLine("enqueued right: {0}", node.right.val);
                }

                Console.WriteLine();
                nodeCountOnLevel++;
            }
        }

        private static bool IsNodeAtEndOfLevel(int nodeCount, int levelCount)
        {
            return Math.Abs(nodeCount - Math.Pow(2, levelCount)) < 0.0001;
        }
    }
}
