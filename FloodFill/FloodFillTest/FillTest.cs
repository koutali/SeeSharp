using FloodFill;
using Xunit;

namespace FloodFillTest
{
    public class FillTest
    {
        [Fact]
        public void Test1()
        {
            var image = new int[3][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };

            const int sr = 1;
            const int sc = 1;
            const int newColor = 2;

            image = Fill.FloodFill(image, sr, sc, newColor);

            Assert.Equal(image[0][0], newColor);
            Assert.Equal(image[0][1], newColor); 
            Assert.Equal(image[0][2], newColor);

            Assert.Equal(image[1][0], newColor);
            Assert.Equal(image[1][1], newColor);
            Assert.Equal(0, image[1][2]); 
            
            Assert.Equal(image[2][0], newColor);
            Assert.Equal(0, image[2][1]);
            Assert.Equal(1, image[2][2]);
        }

        [Fact]
        public void Test2()
        {
            var image = new int[2][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };

            const int sr = 0;
            const int sc = 0;
            const int newColor = 2;

            image = Fill.FloodFill(image, sr, sc, newColor);

            Assert.Equal(image[0][0], newColor);
            Assert.Equal(image[0][1], newColor);
            Assert.Equal(image[0][2], newColor);

            Assert.Equal(image[1][0], newColor);
            Assert.Equal(image[1][1], newColor);
            Assert.Equal(2, image[1][2]);
        }

        [Fact]
        public void Test3()
        {
            var image = new int[2][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 }
            };

            const int sr = 1;
            const int sc = 1;
            const int newColor = 2;

            image = Fill.FloodFill(image, sr, sc, newColor);

            Assert.Equal(0, image[0][0]);
            Assert.Equal(0, image[0][1]);
            Assert.Equal(0, image[0][2]);

            Assert.Equal(0, image[1][0]);
            Assert.Equal(image[1][1], newColor);
            Assert.Equal(0, image[1][2]);
        }
    }
}