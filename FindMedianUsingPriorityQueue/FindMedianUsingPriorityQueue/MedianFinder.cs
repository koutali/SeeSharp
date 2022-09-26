namespace FindMedianUsingPriorityQueue
{
    public class MedianFinder
    {
        private PriorityQueue<int, int> minHeap;
        private PriorityQueue<int, int> maxHeap;

        public MedianFinder()
        {
            minHeap = new PriorityQueue<int, int>();
            maxHeap = new PriorityQueue<int, int>(new IntMaxComparer());
        }

        public void AddNum(int num)
        {
            minHeap.Enqueue(num, num);

            var sizesRoughlySame = false;
            var minHeapLessThanMaxHeap = false;

            while (true)
            {
                if (minHeapLessThanMaxHeap && sizesRoughlySame)
                    break;

                if (maxHeap.Count - minHeap.Count > 1) 
                {
                    var max = maxHeap.Dequeue();
                    minHeap.Enqueue(max, max);
                }
                else if (minHeap.Count - maxHeap.Count > 1)
                {
                    var min = minHeap.Dequeue();
                    maxHeap.Enqueue(min, min);
                }
                else
                {
                    sizesRoughlySame = true;
                }

                if (maxHeap.Count > 0 && minHeap.Count > 0)
                {
                    if (maxHeap.Peek() > minHeap.Peek())
                    {
                        var max = maxHeap.Dequeue();
                        minHeap.Enqueue(max, max);
                    }
                    else
                    {
                        minHeapLessThanMaxHeap = true;
                    }
                }
                else
                {
                    minHeapLessThanMaxHeap = true;
                }
            }
        }

        public double FindMedian()
        {
            if (maxHeap.Count == minHeap.Count)
            {
                return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
            }

            return maxHeap.Count > minHeap.Count ? maxHeap.Peek() : minHeap.Peek();
        }
    }
}