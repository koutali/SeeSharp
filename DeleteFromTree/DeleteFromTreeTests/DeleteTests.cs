using DeleteFromTree;
using Xunit;

namespace DeleteFromTreeTests
{
    public class DeleteTests
    {
        [Fact]
        public void DeleteNodeWithTwoChildrenTest()
        {
            var root = new TreeNode(5);

            Tree.Insert(ref root, 6);
            Tree.Insert(ref root, 3);
            Tree.Insert(ref root, 2);
            Tree.Insert(ref root, 4);
            Tree.Insert(ref root, 7);

            root = Tree.DeleteNode(root, 3);

            var nodes = Tree.TraverseTree(root);
            Assert.DoesNotContain(3, nodes);
        }

        [Fact]
        public void DeleteRootNode()
        {
            var root = new TreeNode(5);

            Tree.Insert(ref root, 6);
            Tree.Insert(ref root, 3);
            Tree.Insert(ref root, 2);
            Tree.Insert(ref root, 4);
            Tree.Insert(ref root, 7);

            root = Tree.DeleteNode(root, 5);

            var nodes = Tree.TraverseTree(root);
            Assert.DoesNotContain(5, nodes);
        }

        [Fact]
        public void DeleteNodeWithTwoChildrenTest2()
        {
            var root = new TreeNode(50);
            
            Tree.Insert(ref root, 30);
            Tree.Insert(ref root, 40);
            Tree.Insert(ref root, 70);
            Tree.Insert(ref root, 60);
            Tree.Insert(ref root, 80);

            root = Tree.DeleteNode(root, 50);

            var nodes = Tree.TraverseTree(root);
            Assert.DoesNotContain(50, nodes);
        }

        [Fact]
        public void DeleteNodeWithOneChildTest()
        {
            var root = new TreeNode(5);

            Tree.Insert(ref root, 6);
            Tree.Insert(ref root, 3);
            Tree.Insert(ref root, 2);
            Tree.Insert(ref root, 4);
            Tree.Insert(ref root, 7);

            root = Tree.DeleteNode(root, 6);

            var nodes = Tree.TraverseTree(root);
            Assert.DoesNotContain(6, nodes);
        }

        [Fact]
        public void DeleteNodeWithNoChildrenTest()
        {
            var root = new TreeNode(5);

            Tree.Insert(ref root, 6);
            Tree.Insert(ref root, 3);
            Tree.Insert(ref  root, 2);
            Tree.Insert(ref root, 4);
            Tree.Insert(ref root, 7);

            root = Tree.DeleteNode(root, 4);

            var nodes = Tree.TraverseTree(root);
            Assert.DoesNotContain(4, nodes);
        }

        [Fact]
        public void DeleteNodeWithNoChildrenTest2()
        {
            var root = new TreeNode(0);
            root = Tree.DeleteNode(root, 0);
            var nodes = Tree.TraverseTree(root);
            Assert.Empty(nodes);
        }
    }
}