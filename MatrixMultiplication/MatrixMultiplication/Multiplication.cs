using System;

namespace MatrixMultiplication
{
    public class Multiplication
    {
        public static int[][] Multiply(int[][] mat1, int[][] mat2)
        {
            if (mat1 == null)
                throw new ArgumentException(nameof(mat1));

            if (mat2 == null)
                throw new ArgumentException(nameof(mat2));

            var mRow = mat1.GetLength(0);
            var nCol = mat2[0].Length;

            if (mRow <= 0)
                throw new ArgumentException(nameof(mRow));

            if (nCol <= 0)
                throw new ArgumentException(nameof(nCol));

            var mat3 = new int[mRow][];
            for (var i = 0; i < mRow; i++)
            {
                mat3[i] = new int[nCol];
            }

            var k = mat1[0].Length;

            for (var row = 0; row < mRow; row++)
            {
                for (var col = 0; col < nCol; col++)
                {
                    for (var i = 0; i < k; i++)
                    {
                        mat3[row][col] += mat1[row][i] * mat2[i][col];
                    }
                }
            }

            return mat3;
        }

        public static int[,] Multiply(int[,] mat1, int[,] mat2)
        {
            if (mat1 == null)
                throw new ArgumentException(nameof(mat1));

            if (mat2 == null)
                throw new ArgumentException(nameof(mat2));

            var mRow = mat1.GetLength(0);
            var nCol = mat2.GetLength(1);

            if (mRow <= 0)
                throw new ArgumentException(nameof(mRow));

            if (nCol <= 0)
                throw new ArgumentException(nameof(nCol));

            var mat3 = new int[mRow, nCol];

            var k = mat1.GetLength(1);

            for (var row = 0; row < mRow; row++)
            {
                for (var col = 0; col < nCol; col++)
                {
                    for (var i = 0; i < k; i++)
                    {
                        mat3[row, col] += mat1[row, i] * mat2[i, col];
                    }
                }
            }

            return mat3;
        }
    }
}
