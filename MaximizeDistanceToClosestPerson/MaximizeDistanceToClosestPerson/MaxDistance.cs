namespace MaximizeDistanceToClosestPerson
{
    public class MaxDistance
    {
        public static int MaxDistToClosest(int[] seats)
        {
            int maxDistance = 0, currentDistance = 0;

            for (var i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1)
                {
                    // handling the free left-end case (currentDistance is equal to i until the first occupied seat is reached)
                    if (currentDistance != i) 
                        currentDistance = (currentDistance + 1) / 2;

                    maxDistance = Math.Max(currentDistance, maxDistance);
                    currentDistance = 0;
                }
                else 
                    currentDistance++;
            }

            // handling the free right-end case
            return Math.Max(currentDistance, maxDistance);
        }
    }
}