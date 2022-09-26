using System;
using System.Collections.Generic;

namespace DeleteFromTree
{
    public class Tree
    {
        #region public

        public static TreeNode DeleteNode(TreeNode node, int key)
        {
            if (node == null)
            {
                return null;
            }

            if (key == node.val)
            {
                // no child
                if (node.left == null && node.right == null)
                {
                    return null;
                }

                // one child
                if (node.left == null && node.right != null)
                {
                    return node.right;
                }

                if (node.left != null && node.right == null)
                {
                    return node.left;
                }

                // two children
                // two children
                if (node.left != null && node.right != null)
                {
                    // find maximum on the left tree
                    var minOnRight = FindMinOnRight(node.right);
                    minOnRight.left = node.left;
                    return node.right;
                }
            }

            if (key > node.val)
            {
                node.right = DeleteNode(node.right, key);
            }

            if (key < node.val)
            {
                node.left = DeleteNode(node.left, key);
            }

            return node;
        }

        public static void Insert(ref TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
            }

            if (val > root.val)
            {
                Insert(ref root.right, val);
            }

            if (val < root.val)
            {
                Insert(ref root.left, val);
            }
        }

        public static int FindTilt(TreeNode root)
        {
            var tilt = FindTiltRecursive(root);
            if (tilt < 0)
                tilt *= -1;

            return tilt;
        }

        public static List<int> TraverseTree(TreeNode root)
        {
            var nodes = new List<int>();
            TraverseRecursive(root, nodes);
            return nodes;
        }
        
        #endregion

        #region private

        private static TreeNode FindMinOnRight(TreeNode node)
        {
            while (node.left != null)
            {
                node = node.left;
            }

            return node;
        }

        private static void TraverseRecursive(TreeNode node, IList<int> nodes)
        {
            if (node == null)
                return;

            if (node.left != null)
                TraverseRecursive(node.left, nodes);

            nodes.Add(node.val);

            if (node.right != null)
                TraverseRecursive(node.right, nodes);
        }

        private static int FindTiltRecursive(TreeNode node)
        {
            Console.WriteLine(node.val);

            if (node.left == null && node.right == null)
                return 0;

            if (node.left == null && node.right != null)
            {
                return node.right.val;
            }

            if (node.left != null && node.right == null)
            {
                return node.left.val;
            }

            return FindTiltRecursive(node.left) - FindTiltRecursive(node.right);
        }

        #endregion
    }
}
