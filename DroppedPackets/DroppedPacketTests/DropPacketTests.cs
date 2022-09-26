using DroppedPackets;
using Xunit;

namespace DroppedPacketTests
{
    public class DropPacketTests
    {
        [Fact]
        public void Test1()
        {
            var requests = new int[] { 1,1,1,1,2,2,2,3,3,3,4,4,4,5,5,5,6,6,6,7,7,7,7,11,11,11,11 };
            Assert.Equal(7, DropPacket.NumberOfDroppedPackets(requests));
        }
    }
}
