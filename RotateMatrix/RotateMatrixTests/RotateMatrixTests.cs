using Xunit;

namespace RotateMatrixTests
{
    public class RotateMatrixTests
    {
        [Fact]
        public void Test1()
        {
            var input = new[]
            {
                new[] { 1, 2 },
                new[] { 3, 4 }
            };

            var output = new[]
            {
                new[] { 3, 1 },
                new[] { 4, 2 }
            };

            RotateMatrix.RotateMatrix.Rotate(input);

            Assert.Equal(output.Length, input.Length);
            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(input[i].Length, output[i].Length);
                for (var j = 0; j < output[i].Length; j++)
                {
                    Assert.Equal(output[i][j], input[i][j]);
                }
            }
        }

        [Fact]
        public void Test2()
        {
            var input = new[]
            {
                new[] { 1 }
            };

            var output = new[]
            {
                new[] { 1 }
            };

            RotateMatrix.RotateMatrix.Rotate(input);

            Assert.Equal(output.Length, input.Length);
            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(input[i].Length, output[i].Length);
                for (var j = 0; j < output[i].Length; j++)
                {
                    Assert.Equal(output[i][j], input[i][j]);
                }
            }
        }

        [Fact]
        public void Test3()
        {
            var input = new[]
            {
                new[] { 5,1,9,11 },
                new[] { 2, 4, 8, 10 },
                new[] { 13,3,6,7 },
                new[] { 15, 14, 12, 16 }
            };

            var output = new[]
            {
                new[] {15,13,2,5 },
                new[] { 14, 3, 4, 1 },
                new[] {12,6,8,9 },
                new[] { 16, 7, 10, 11 }
            };

            RotateMatrix.RotateMatrix.Rotate(input);

            Assert.Equal(output.Length, input.Length);
            for (var i = 0; i < output.Length; i++)
            {
                Assert.Equal(input[i].Length, output[i].Length);
                for (var j = 0; j < output[i].Length; j++)
                {
                    Assert.Equal(output[i][j], input[i][j]);
                }
            }
        }
    }
}
