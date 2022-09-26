using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeIntervals
{
    public class MergeIntervals
    {
        #region public
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals == null)
            {
                throw new ArgumentException(nameof(intervals));
            }

            Sort(intervals);

            var toProcess = intervals.Select(a => a.ToList()).ToList();

            for (var i = 0; i < toProcess.Count - 1; i++)
            {
                var first = toProcess.ElementAt(i);
                var second = toProcess.ElementAt(i + 1);

                if (!DoesSecondLieWithinRange(first, second)) 
                    continue;

                toProcess.Remove(second);
                toProcess[i] = MergeArrays(first, second);
                i--;
            }

            return toProcess.Select(a => a.ToArray()).ToArray();
        }
        #endregion

        #region private

        private static void Sort<T>(T[][] data, int col = 0)
        {
            var comparer = Comparer<T>.Default;
            Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
        }

        private static List<int> MergeArrays(List<int> first, IEnumerable<int> second)
        {
            var secondOfFirst = first.ElementAt(1);
            var secondOfSecond = second.ElementAt(1);

            if (secondOfSecond >= secondOfFirst)
            {
                first[1] = secondOfSecond;
            }

            return first;
        }

        private static bool DoesSecondLieWithinRange(IReadOnlyCollection<int> first, IEnumerable<int> second)
        {
            var firstOfFirst = first.ElementAt(0);
            var secondOfFirst = first.ElementAt(1);

            var firstOfSecond = second.ElementAt(0);

            return (firstOfSecond >= firstOfFirst && firstOfSecond <= secondOfFirst);
        }

        #endregion
    }
}
