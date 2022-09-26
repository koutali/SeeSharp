namespace FindLongestChain
{
    public class LongestChain
    {
        public static int FindLongestChain(int[][] pairs)
        {
            var pairList = new List<Pair>();
            foreach (var pair in pairs)
            {
                var newPair = new Pair(pair[0], pair[1]);
                pairList.Add(newPair);
            }

            // here I have a list of sorted elements
            pairList.Sort();

            var maxChainLength = 1;
            var chainLength = 1;
            var nextToVisit = 0;
            for (var i = 0; i < pairList.Count; i++)
            {
                for (var j = i+1; j < pairList.Count; j++)
                {
                    if (pairList[i].Right >= pairList[j].Left)
                    {
                        continue;
                    }

                    if (nextToVisit == 0) // assign once only
                    {
                        nextToVisit = i+1;
                    }

                    chainLength++;
                    i = j;
                }

                if (chainLength > maxChainLength)
                {
                    maxChainLength = chainLength;
                }

                // initial assignments 
                chainLength = 1;

                if (nextToVisit == 0) 
                    continue;

                i = nextToVisit-1;
                nextToVisit = 0;
            }

            return maxChainLength;
        }
    }
}