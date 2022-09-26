using System.Collections.Generic;
using Xunit;
using ZigZagLevelOrder;

namespace ZigZagTests
{
    public class ZigZagTests
    {
        [Fact]
        public void TreeWithLeavesOnAllLevelsReturns2DList()
        {
            var tree = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                },
            };

            var list = new List<List<int>>()
            {
                new List<int>(){3},
                new List<int>(){20,9},
                new List<int>(){15,7}
            };

            var returned = ZigZag.ZigzagLevelOrder(tree);
            Assert.Equal(list, returned);
        }

        [Fact]
        public void OnlyRootReturns2DListWithOneElement()
        {
            var tree = new TreeNode(1)
            ;

            var list = new List<List<int>>()
            {
                new List<int>(){1}
            };

            var returned = ZigZag.ZigzagLevelOrder(tree);
            Assert.Equal(list, returned);
        }

        [Fact]
        public void NullTreeReturnsEmptyList()
        {
            var returned = ZigZag.ZigzagLevelOrder(null);
            Assert.Empty(returned);
        }

        [Fact]
        public void TreeHasOneLeafOnEachLevel()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                },
            };

            var list = new List<List<int>>()
            {
                new List<int>(){1},
                new List<int>(){3,2},
                new List<int>(){4,5}
            };

            var returned = ZigZag.ZigzagLevelOrder(tree);
            Assert.Equal(list, returned);
        }
    }
}