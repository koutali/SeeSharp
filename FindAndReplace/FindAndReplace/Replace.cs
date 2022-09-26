using System;
using System.Text;

namespace FindAndReplace
{
    public class Replace
    {
        public static string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(nameof(s));
            }

            if (!(indices.Length == sources.Length && sources.Length == targets.Length))
            {
                throw new ArgumentException("different size of arrays");
            }

            var sb = new StringBuilder();
            foreach (var ch in s)
            {
                sb.Append(ch);
            }

            for (var i = 0; i < sources.Length; i++)
            {
                if (indices[i] < 0 || indices[i] > s.Length)
                    continue;

                var substring = s.Substring(indices[i], sources[i].Length);
                if (!substring.Equals(sources[i]))
                {
                    continue;
                }

                var indexInStringBuilder = sb.ToString().IndexOf(sources[i], indices[i], StringComparison.Ordinal);
                if (indexInStringBuilder == -1)
                {
                    continue;
                }

                sb.Remove(indexInStringBuilder, sources[i].Length);
                sb.Insert(indexInStringBuilder, targets[i], 1);
            }

            return sb.ToString();
        }
    }
}
