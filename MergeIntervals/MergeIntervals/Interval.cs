namespace MergeIntervals
{
    public class Interval
    {
        public static int[][] Merge(int[][] intervals)
        {
            var intervalList = MakeSortedListOfPairs(intervals);

            for (var i = 0; i < intervalList.Count; i++)
            {
                var end = intervalList[i].Right;
                for (var j = i+1; j < intervalList.Count; j++)
                {
                    if (intervalList[i].Right < intervalList[j].Left)
                        continue;

                    if (intervalList[i].Right > intervalList[j].Right)
                    {
                        intervalList.RemoveAt(j);
                        j--;
                        continue;
                    }

                    if (intervalList[j].Right < intervalList[i].Right) 
                        continue;

                    intervalList[i].Right = intervalList[j].Right;
                    intervalList.RemoveAt(j);
                    j--; // to prevent skipping items because of loop increment
                }
            }

            return Make2DMergedIntervals(intervalList);
        }

        private static int[][] Make2DMergedIntervals(List<Pair> mergedIntervals)
        {
            var merged2DIntervals = new int[mergedIntervals.Count][];

            for (var i = 0; i < mergedIntervals.Count; i++)
            {
                merged2DIntervals[i] = new int[2];
                merged2DIntervals[i][0] = mergedIntervals[i].Left;
                merged2DIntervals[i][1] = mergedIntervals[i].Right;
            }

            return merged2DIntervals;
        }

        private static List<Pair> MakeSortedListOfPairs(int[][] intervals)
        {
            var intervalList = intervals.Select(t => new Pair(t[0], t[1])).ToList();

            intervalList.Sort();
            return intervalList;
        }
    }
}