namespace KClosestPointsToOrigin
{
    public class Sort2dArray
    {
        public static int[][] KClosest(int[][] points, int k)
        {
            var distances = new Dictionary<int, List<int>>();
            foreach (var point in points)
            {
                var x = point[0];
                var y = point[1];

                var distance = x * x + y * y;
                if (!distances.ContainsKey(distance))
                {
                    distances.Add(distance, new List<int>(){x,y});
                }
                else
                {
                    distances[distance].Add(x);
                    distances[distance].Add(y);
                }
            }

            distances = distances.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            var i = 0;
            var kClosestPoints = new int[k][];
            foreach (var distance in distances)
            {
                if (i == k)
                    break;

                var index = 0;
                while (index < distance.Value.Count)
                {
                    kClosestPoints[i] = new int[2];
                    kClosestPoints[i][0] = distance.Value[index++];
                    kClosestPoints[i][1] = distance.Value[index++];
                    i++;
                }
            }

            return kClosestPoints;
        }
    }
}