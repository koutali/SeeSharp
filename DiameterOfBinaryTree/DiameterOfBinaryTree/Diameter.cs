using System;

namespace DiameterOfBinaryTree
{
    public class Diameter
    {
        public static int DiameterOfBinaryTree(TreeNode node)
        {
            return Math.Max(PathDoesntGoThroughRoot(node), PathGoesThroughRoot(node));
        }

        private static int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;       

            var left =  1 + GetHeight(node.left);
            var right = 1 + GetHeight(node.right);             

            return Math.Max(left, right) + 1;
        }

        private static int PathGoesThroughRoot(TreeNode node)
        {
            var left = GetHeight(node.left);
            var right = GetHeight(node.right);
            return left + right;
        }

        private static int PathDoesntGoThroughRoot(TreeNode node)
        {
            return Math.Max(DiameterOfBinaryTree(node.left), DiameterOfBinaryTree(node.right));
        }  
    }
}
