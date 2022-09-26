using BinaryTreeDeleteRecursive;
using Xunit;

namespace BinaryTreeRecursiveDeleteTest
{
    public class DeleteTreeNodeTests
    {
        [Fact]
        public void TestDeleteRecursive()
        {
            var tree = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode(2)
                },
                right = new TreeNode()
                {
                    val =3,
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                }
            };

            var returned = DeleteTreeNode.RemoveLeafNodes(tree, 2);

            var expected = new TreeNode(1)
            {
                right = new TreeNode(3)
                {
                    right = new TreeNode(4)
                }
            };

            Assert.Equal(expected, returned);
        }
    }
}