using System.Collections.Generic;
using System.Linq;

namespace BackspaceCompare
{
    public class Compare
    {
        public static bool BackspaceCompare(string s, string t)
        {
            var first = DeleteCharAfterHash(s);
            var second = DeleteCharAfterHash(t);

            if (first.Count != second.Count)
            {
                return false;
            }

            while (first.Any() && second.Any())
            {
                var firstPopped = first.Pop();
                var secondPopped = second.Pop();

                if (firstPopped != secondPopped)
                {
                    return false;
                }
            }

            return true;
        }

        private static Stack<char> DeleteCharAfterHash(string s)
        {
            var stackOfChars = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '#')
                {
                    if (!stackOfChars.Any())
                    {
                        continue;
                    }

                    stackOfChars.Pop();
                }
                else
                {
                    stackOfChars.Push(c);
                }
            }

            return stackOfChars;
        }
    }
}
