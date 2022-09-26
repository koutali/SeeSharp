namespace MergeIntervals
{
    internal class Pair: IComparable<Pair>
    {
        public int Left;
        public int Right;

        public Pair(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public int CompareTo(Pair? other)
        {
            if (other == null)
                return 1;
            if (Left > other.Left)
                return 1;
            if (Left < other.Left)
                return -1;

            return 0;
        }
    }
}
