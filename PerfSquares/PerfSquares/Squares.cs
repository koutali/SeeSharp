using System.Collections.Generic;
using System.Linq;

namespace PerfSquares
{
    public class Squares
    {
        private List<int> squares = new List<int>();
        private Dictionary<int, int> cache = new Dictionary<int, int>();
        public int NumSquares(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                squares.Add(i*i);
            }

            squares = squares.Where(x => x <= n).ToList();

            return NumSquaresHelper(n);
        }

        private int NumSquaresHelper(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n < 0)
            {
                return -1;
            }

            if (cache.ContainsKey(n))
            {
                return cache[n];
            }

            var min = int.MaxValue;
            foreach (var square in squares)
            {
                var num = NumSquaresHelper(n - square);
                if (num >= 0 && num < min)
                {
                    min = 1 + num;
                }
            }

            cache[n] = min;
            return cache[n];
        }
    }
}
