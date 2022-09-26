using System.Linq;

namespace RotateMatrix
{
    public class RotateMatrix
    {
        public static void Rotate(int[][] matrix)
        {
            // transpose
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = i+1; j < matrix[i].Length; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }

            // reverse each row
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i] = matrix[i].Reverse().ToArray();
            }
        }
    }
}
