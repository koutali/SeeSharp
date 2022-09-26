using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codec
{
    public class Codec
    {
        #region public
        public string Serialize(TreeNode root)
        {
            var sb = new StringBuilder();
            BFS(root, sb);
            return sb.ToString().TrimEnd(',');
        }

		// Decodes your encoded data to tree.
		public TreeNode Deserialize(string data)
        {
            if (data == "")
                return null;

            var nodes = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<TreeNode>();
            var root = new TreeNode(int.Parse(nodes[0]));
            queue.Enqueue(root);

            for (var i = 1; i < nodes.Length; i++)
            {
                var curr = queue.Dequeue();
                if (nodes[i] != "null")
                {
                    var left = new TreeNode(int.Parse(nodes[i]));
                    curr.left = left;
                    queue.Enqueue(left);
                }

                if (nodes[++i] != "null")
                {
                    var right = new TreeNode(int.Parse(nodes[i]));
                    curr.right = right;
                    queue.Enqueue(right);
                }
            }

            return root;
        }

        private static void CleanUp(TreeNode node)
        {
            if (node == null)
                return;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                node = queue.Dequeue();

                if (node.left is { val: int.MinValue })
                {
                    node.left = null;
                }

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is { val: int.MinValue })
                {
                    node.right = null;
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        public static bool AreEqual(TreeNode first, TreeNode second)
        {
            if (first == null && second != null)
            {
                return false;
            }

            if (first != null && second == null)
            {
                return false;
            }

            if (first != null && second != null && first.val == second.val)
            {
                return true;
            }

            return AreEqual(first.left, second.left) && AreEqual(first.right, second.right);
        }

        #endregion

        #region private
        private void InsertToTree(TreeNode node, string toInsert)
        {
            var key = 0;
            if (!toInsert.Equals("null"))
            {
                var conversionOk = ConvertToInt(toInsert, out key);
                if (!conversionOk)
                {
                    Console.WriteLine("Input contains non-integer value, insertion failed.");
                    return;
                }
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                node = queue.Dequeue();

                if (node.left == null)
                {
                    node.left = toInsert.Equals("null") ? new TreeNode(int.MinValue) : new TreeNode(key);
                    break;
                }

                if (node.left.val != int.MinValue)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right == null)
                {
                    node.right = toInsert.Equals("null") ? new TreeNode(int.MinValue) : new TreeNode(key);
                    break;
                }

                if (node.right.val != int.MinValue)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        private static bool ConvertToInt(string toConvert, out int convertedValue)
        {
            try
            {
                convertedValue = int.Parse(toConvert);
                return true;
            }
            catch (FormatException)
            {
                convertedValue = int.MinValue;
                return false;
            }
        }

        private static void BFS(TreeNode node, StringBuilder sb)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var dequeuedNode = queue.Dequeue();
                if (dequeuedNode == null)
                {
                    if (QueueHasValuesOtherThanNull(queue))
                    {
                        sb.Append("null");
                        sb.Append(",");
                    }

                    continue;
                }

                sb.Append(dequeuedNode.val);
                sb.Append(",");

                queue.Enqueue(dequeuedNode.left);
                queue.Enqueue(dequeuedNode.right);
            }
        }

        private static bool QueueHasValuesOtherThanNull(Queue<TreeNode> queue)
        {
            return queue.Count(x => x == null) != queue.Count;
        }

        #endregion
    }
}
