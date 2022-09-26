namespace FindMedianUsingPriorityQueue
{
    internal class IntMaxComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
