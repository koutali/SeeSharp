namespace BinaryTreeDeleteRecursive
{
    public class DeleteTreeNode
    {
        public static TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null)
                return null;

            if (root.val == target)
            {
                if (root.left == null && root.right == null)
                {
                    return null;
                }

                var left = RemoveLeafNodes(root.left, target);
                var right = RemoveLeafNodes(root.right, target);
                if (left == null && right == null)
                {
                    return null;
                }

                root.left = left;
                root.right = right;
                return root;
            }
            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);
            return root;

        }
    }
}
