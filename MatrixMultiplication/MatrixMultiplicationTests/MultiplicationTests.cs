using System;
using MatrixMultiplication;
using Xunit;

namespace MatrixMultiplicationTests
{
    public class MultiplicationTests
    {
        [Fact]
        public void MultiDimArray_Test()
        {
            var mat1 = new int[2, 3]
            {
                { 1, 0, 0},
                {-1, 0, 3}
            };

            var mat2 = new int[3, 3]
            {
                {7, 0, 0},
                {0, 0, 0},
                {0, 0, 1}
            };

            var expected = new int[2, 3]
            {
                {7,0,0 },
                {-7,0,3 }
            };

            var returned = Multiplication.Multiply(mat1, mat2);

            Assert.Equal(expected.GetLength(0), returned.GetLength(0));
            Assert.Equal(expected.GetLength(1), returned.GetLength(1));
            for (var i = 0; i < expected.GetLength(0); i++)
            {
                for (var j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.Equal(expected[i, j], returned[i, j]);
                }
            }
        }

        [Fact]
        public void JaggedArray_Test()
        {
            var mat1 = new int[2][];
            mat1[0] = new[] { 1, 0, 0 };
            mat1[1] = new[] { -1, 0, 3 };

            var mat2 = new int[3][];
            mat2[0] = new[] { 7, 0, 0 };
            mat2[1] = new[] { 0, 0, 0 };
            mat2[2] = new[] { 0, 0, 1 };

            var expected = new int[2][];
            expected[0] = new[] { 7, 0, 0 };
            expected[1] = new[] { -7, 0, 3 };

            var returned = Multiplication.Multiply(mat1, mat2);

            Assert.Equal(expected.GetLength(0), returned.GetLength(0));
            Assert.Equal(expected[0].Length, returned[0].Length);
            for (var i = 0; i < expected.GetLength(0); i++)
            {
                for (var j = 0; j < expected[i].Length; j++)
                {
                    Assert.Equal(expected[i][j], returned[i][j]);
                }
            }
        }
    }
}
