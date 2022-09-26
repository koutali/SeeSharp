using System;
using System.Collections.Generic;
using System.Linq;

namespace AboveAverageSubArray
{
    public class AboveAverageSubArray
    {
        #region public

        public static SubArray[] AboveAverageSubArrays(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException(nameof(A));
            }

            var list = new List<SubArray>();

            var totalSum = A.Sum();
            for (var i = 0; i < A.Length; i++)
            {
                var sumCurrent = 0;
                for (var j = i; j < A.Length; j++)
                {
                    sumCurrent += A[j];

                    var currentNumberOfElements = (j - i + 1);
                    var currentAverage = sumCurrent / currentNumberOfElements;
                    var remainingElements = A.Length - currentNumberOfElements;

                    if (remainingElements <= 0)
                    {
                        remainingElements = 1;
                    }

                    var remainingAverage = (totalSum - sumCurrent) / remainingElements;
                    if (currentAverage > remainingAverage)
                    {
                        list.Add(new SubArray(i + 1, j + 1));
                    }
                }
            }
            return list.ToArray();
        }

        #endregion
    }

    public class SubArray
    {
        #region MyRegion

        private readonly int Left;
        private readonly int Right;

        #endregion

        #region public

        public SubArray(int left, int right)
        {
            if (left < 0)
            {
                throw new ArgumentException(nameof(left));
            }

            if (right < 0)
            {
                throw new ArgumentException(nameof(right));
            }

            Left = left;
            Right = right;
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || this.GetType() != obj.GetType())
            {
                return false;
            }

            var p = (SubArray)obj;
            return (Left == p.Left) && (Right == p.Right);
        }

        protected bool Equals(SubArray other)
        {
            return Left == other.Left && Right == other.Right;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Left, Right);
        }

        #endregion
    }
}
