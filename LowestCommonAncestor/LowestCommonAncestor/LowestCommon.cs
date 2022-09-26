namespace LowestCommonAncestor
{
    public class LowestCommon
    {
        public static TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;

            var pPath = GetPath(root, p);
            var qPath = GetPath(root, q);
            var common = pPath.Intersect(qPath).ToList();

            return common[0];
        }

        private static List<TreeNode> GetPath(TreeNode start, TreeNode destination)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(start);
            
            var previousNode = new Dictionary<TreeNode, TreeNode>();
            previousNode.Add(start, start);

            while(q.Any())
            {
                var dequeue = q.Dequeue();
                if (dequeue == destination)
                    break;

                if(dequeue.left != null)
                {
                    q.Enqueue(dequeue.left);
                    previousNode.Add(dequeue.left, dequeue);
                }

                if(dequeue.right != null)
                {
                    q.Enqueue(dequeue.right);
                    previousNode.Add(dequeue.right, dequeue);
                }
            }

            var path = new List<TreeNode>
            {
                destination
            };

            var  currentNode = previousNode[destination];
            while (currentNode != start)
            {
                path.Add(currentNode);
                currentNode = previousNode[currentNode];
            } 
            path.Add(currentNode);

            return path;
        }
    }
}