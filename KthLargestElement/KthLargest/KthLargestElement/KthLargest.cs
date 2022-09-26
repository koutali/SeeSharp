namespace KthLargestElement
{
    public class KthLargest
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            var priorityQueue = new PriorityQueue<int, int>();
            foreach (var num in nums)
            {
                priorityQueue.Enqueue(num, num);
            }

            var element = priorityQueue.Peek();
            var indexFromStart = nums.Length - k;
            for (var i = 0; i <= indexFromStart; i++)
            {
                element = priorityQueue.Dequeue();
            }

            return element;
        }
    }
}