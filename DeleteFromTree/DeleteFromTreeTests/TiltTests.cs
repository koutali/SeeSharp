using DeleteFromTree;
using Xunit;

namespace DeleteFromTreeTests
{
    public class TiltTests
    {
        [Fact]
        public void TiltTest()
        {
            var root = new TreeNode(1);
            Tree.Insert(ref root, 3);
            Tree.Insert(ref root, 2);

            var tilt = Tree.FindTilt(root);
            Assert.Equal(1, tilt);
        }
    }
}
