using BinaryTreeMaxPath;
using BinaryTreeMaxPathSum;
using Xunit;

namespace MaxPathSumTests
{
    public class PathSumTests
    {
        [Fact]
        public void MiniTree()
        {
            var tree = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                },
                right = new TreeNode()
                {
                    val = 3
                }
            };

            var expected = 6;
            var returned = PathSum.MaxPathSum(tree);
            Assert.Equal(expected, returned);
        }
    }
}