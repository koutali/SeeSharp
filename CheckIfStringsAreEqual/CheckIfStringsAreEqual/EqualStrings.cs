using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckIfStringsAreEqual
{
    public class EqualStrings
    {
        public static bool BackspaceCompare(string s, string t)
        {
            var removed1 = Remove(s);
            var removed2 = Remove(t);
            return removed1.Equals(removed2);
        }

        private static string Remove(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c != '#')
                    stack.Push(c);
                else if (stack.Any())
                    stack.Pop();
            }

            var sb = new StringBuilder();
            while (stack.Any())
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }
    }
}
