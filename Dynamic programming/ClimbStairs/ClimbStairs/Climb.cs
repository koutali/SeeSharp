namespace ClimbStairs
{
    public class Climb
    {
        public static int ClimbStairs(int n)
        {
            if(n < 0) return 0;

            int[] ways = new int[n+1];
            ways[0] = 0;
            ways[1] = 1;
            ways[2] = 2;

            for (int i = 3; i < ways.Length; i++)
                ways[i] = ways[i - 2] + ways[i - 1];
            
            return ways[n];
        }
    }
}