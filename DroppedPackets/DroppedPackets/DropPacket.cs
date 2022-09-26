using System.Collections.Generic;
using System.Linq;

namespace DroppedPackets
{
    public class DropPacket
    {
        public static int NumberOfDroppedPackets(int[] requests)
        {
            var oneSecRequests = new Dictionary<int, int>();
            foreach (var request in requests)
            {
                if (!oneSecRequests.ContainsKey(request))
                    oneSecRequests.Add(request, 1);
                else
                    oneSecRequests[request]++;
            }

            var sum = oneSecRequests.Values.Where(x => x <= 10).Sum();
            var tenSecRequests = new List<int> { sum };
            var removeFromStart = 0;
            for (var i = 0; i < oneSecRequests.Values.Count; i++)
            {
                if (oneSecRequests.Values.ElementAt(i) <= 10)
                {
                    i++;
                    continue;
                }

                sum -= oneSecRequests.Values.ElementAt(removeFromStart);
                removeFromStart++;
                sum += oneSecRequests.Values.ElementAt(i);
                tenSecRequests.Add(sum);
            }
            
            var dropped = 0;
            sum = 0;
            foreach (var request in tenSecRequests.TakeWhile(request => sum <= 60))
            {
                dropped += request % 20;
                sum += request;
            }

            sum = 0;
            foreach (var request in tenSecRequests.TakeWhile(request => sum != 20))
            {
                dropped += request % 3;
                sum += request;
            }

            return dropped;
        }
    }
}
