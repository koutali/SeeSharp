namespace Tribonacci
{
    public class TribonacciClass
    {
        public static int Tribonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1 || n == 2)
                return 1;

            int[] results = new int[n + 1];
            results[0] = 0;
            results[1] = 1;
            results[2] = 1;
            for (int i = 3; i < results.Length; i++)
                results[i] = results[i - 3] + results[i - 2] + results[i - 1];

            return results[n];
        }
    }
}