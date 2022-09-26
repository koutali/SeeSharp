using FindMedianUsingPriorityQueue;

namespace FindMedianTests
{
    public class MedianFinderTests
    {
        [Fact]
        public void Test1()
        {
            var medianFinder = new MedianFinder();
            
            medianFinder.AddNum(3);
            Assert.Equal(3, medianFinder.FindMedian());

            medianFinder.AddNum(2);
            Assert.Equal(2.5, medianFinder.FindMedian());

            medianFinder.AddNum(7);
            Assert.Equal(3, medianFinder.FindMedian());

            medianFinder.AddNum(4);
            Assert.Equal(3.5, medianFinder.FindMedian());
        }
    }
}