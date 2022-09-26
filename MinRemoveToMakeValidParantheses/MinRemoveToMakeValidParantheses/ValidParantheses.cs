using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidParanthesesTests
{
    public class ValidParantheses
    {
        #region public
        public static string MinRemoveToMakeValid(string s)
        {
            if (s == null)
                throw new ArgumentException(nameof(s));

            // find indices to remove
            var indicesToRemove = FindIndicesToRemove(s);

            var removed = s;
            while (indicesToRemove.Any())
            {
                var index = indicesToRemove.Pop();
                removed = removed.Remove(index, 1);
            }
            return removed;
        }
        #endregion

        #region private
        private static Stack<int> FindIndicesToRemove(string s)
        {
            var indicesToRemove = new Stack<int>();
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == '(')
                {
                    indicesToRemove.Push(i);
                }

                if (ch == ')')
                {
                    if (indicesToRemove.Any())
                    {
                        var peek = indicesToRemove.Peek();
                        if (s[peek] == '(')
                        {
                            indicesToRemove.Pop();
                        }
                        else
                        {
                            indicesToRemove.Push(i);
                        }
                    }
                    else
                    {
                        indicesToRemove.Push(i);
                    }
                }
            }

            return indicesToRemove;
        }
        #endregion
    }
}
