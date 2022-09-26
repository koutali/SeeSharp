namespace ZigZagLevelOrder
{
    public class ZigZag
    {
        public static IList<IList<int>> ZigzagLevelOrder2(TreeNode root)
        {
            var traversedNodes = new List<IList<int>>();
            if (root == null)
                return traversedNodes;

            LevelOrderTraversal(root, traversedNodes);
            return traversedNodes;
        }

        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new();

            if (root == null)
            {
                return result;
            }

            Stack<TreeNode> leftToRight = new();
            Stack<TreeNode> rightToLeft = new();

            leftToRight.Push(root);

            while (leftToRight.Count != 0 || rightToLeft.Count != 0)
            {
                int leftToRightCount = leftToRight.Count;
                int rightToLeftCount = rightToLeft.Count;

                List<int> level = new();

                for (int i = 0; i < leftToRightCount; i++)
                {
                    var popped = leftToRight.Pop();
                    level.Add(popped.val);

                    if (popped.left != null)
                    {
                        rightToLeft.Push(popped.left);
                    }

                    if (popped.right != null)
                    {
                        rightToLeft.Push(popped.right);
                    }
                }

                for (int i = 0; i < rightToLeftCount; i++)
                {
                    var popped = rightToLeft.Pop();
                    level.Add(popped.val);

                    if (popped.right != null)
                    {
                        leftToRight.Push(popped.right);
                    }

                    if (popped.left != null)
                    {
                        leftToRight.Push(popped.left);
                    }
                }

                result.Add(level);
            }

            return result;
        }

        private static void LevelOrderTraversal(TreeNode root, IList<IList<int>> traversedNodes)
        {
            var nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
 
            // populate 2d list
            while (nodeQueue.Any())
            {
                var level = new List<int>();
                var queueLength = nodeQueue.Count;

                for (var i = 0; i < queueLength; i++)
                {
                    var dequeuedNode = nodeQueue.Dequeue();
                    level.Add(dequeuedNode.val);                    
                    if (dequeuedNode.left != null)
                        nodeQueue.Enqueue(dequeuedNode.left);

                    if (dequeuedNode.right != null)
                        nodeQueue.Enqueue(dequeuedNode.right);
                }

                traversedNodes.Add(level);
            }

            // reverse list items which are not a multiple of two
            for (int i = 0; i < traversedNodes.Count; i++)
            {
                if(i % 2 == 1)
                {
                    traversedNodes[i] = traversedNodes[i].Reverse().ToList();
                }
            }
        }
    }
}