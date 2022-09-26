using RectangleOverlap;
using Xunit;

namespace RectangleOverlapTest
{
    public class RectangleTest
    {
        [Fact]
        public void NoOverlap()
        {
            var rect1 = new[] { 5, 15, 8, 18 };
            var rect2 = new[] { 0, 3, 7, 9};

            Assert.False(Rectangle.IsRectangleOverlap(rect1, rect2));
        }

        [Fact]
        public void Overlap()
        {
            var rect1 = new[] { 7, 8, 13, 15 };
            var rect2 = new[] { 10, 8, 12, 20 };

            Assert.True(Rectangle.IsRectangleOverlap(rect1, rect2));
        }
    }
}
