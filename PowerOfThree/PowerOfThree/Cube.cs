using System;

namespace PowerOfThree
{
    public class Cube
    {
        public static bool IsPowerOfThree(int n)
        {
            while (n >= 3.0)
            {
                n /= 3;
            }

            return n == 1;
        }
    }
}
