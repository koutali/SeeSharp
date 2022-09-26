using BinaryTreeMaxPathSum;

namespace BinaryTreeMaxPath
{
    public class PathSum
    {
        private static int sum = 0;
        public static int MaxPathSum(TreeNode root)
        {
            if(root == null)
                return 0;

            sum = root.val;
            TraverseTree(root);
            return sum;
        }

        private static int TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftSum = TraverseTree(root.left);
            var rightSum = TraverseTree(root.right);

            // due to negatives
            leftSum = Math.Max(leftSum, 0);
            rightSum = Math.Max(rightSum, 0);

            // sum calculated with split
            sum = Math.Max(sum, leftSum + rightSum + root.val);

            // value returned without split
            return root.val + Math.Max(leftSum, rightSum);
        }
    }
}