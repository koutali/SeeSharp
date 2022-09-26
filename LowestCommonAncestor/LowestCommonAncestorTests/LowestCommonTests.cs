using LowestCommonAncestor;
using Xunit;

namespace LowestCommonAncestorTests
{
    public class LowestCommonTests
    {
        [Fact]
        public void Test1()
        {
            var firstNode = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            };

            var secondNode = new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(8)
            };

            var tree = new TreeNode(3)
            {
                left = firstNode,
                right = secondNode
            };

            var lowestCommon = LowestCommon.LowestCommonAncestor(tree, firstNode, secondNode);
            Assert.Equal(3, lowestCommon.val);
        }

        [Fact]
        public void Test2()
        {
            var secondNode = new TreeNode(4);
            var firstNode = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = secondNode
                }
            };

            var tree = new TreeNode(3)
            {
                left = firstNode,
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                }
            };

            var lowestCommon = LowestCommon.LowestCommonAncestor(tree, firstNode, secondNode);
            Assert.Equal(5, lowestCommon.val);
        }

        [Fact]
        public void Test3()
        {
            var firstNode = new TreeNode(2);
            var secondNode = new TreeNode(1)
            {
                left = firstNode
            };                       

            var lowestCommon = LowestCommon.LowestCommonAncestor(secondNode, firstNode, secondNode);
            Assert.Equal(1, lowestCommon.val);
        }

        [Fact]
        public void Test4()
        {
            var firstNode = new TreeNode(4);
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = null,
                    right = firstNode
                },
                right = new TreeNode(3)
            };

            var lowestCommon = LowestCommon.LowestCommonAncestor(tree, firstNode, tree);
            Assert.Equal(1, lowestCommon.val);
        }
    }
}