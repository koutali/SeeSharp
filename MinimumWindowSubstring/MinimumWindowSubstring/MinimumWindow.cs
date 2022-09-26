namespace MinimumWindowSubstring
{
    public class MinimumWindow
    {
        public static string MinWindow(string s, string t)
        {
            if (t.Length > s.Length)
                return string.Empty;

            if (s.Equals(t))
                return t;

            var dictionaryOfT = new Dictionary<char, int>();
            foreach (var ch in t)
            {
                if (!dictionaryOfT.ContainsKey(ch))
                    dictionaryOfT.Add(ch, 1);
                else
                    dictionaryOfT[ch]++;
            }

            var minWindow = new Dictionary<char, int>();
            var have = 0;
            var need = dictionaryOfT.Count;

            var substring = string.Empty;
            var left = 0;

            for(var right = 0; right < s.Length; right++)
            {
                var ch = s[right];

                if (!minWindow.ContainsKey(ch))
                    minWindow.Add(ch, 1);
                else
                    minWindow[ch]++;

                if (dictionaryOfT.ContainsKey(ch) && dictionaryOfT[ch] == minWindow[ch])
                    have++;

                while (have == need)
                {
                    substring = s.Substring(left, right - left + 1);
 
                    minWindow[s[left]]--;
                    if(dictionaryOfT.ContainsKey(s[left]) && minWindow[s[left]] < dictionaryOfT[s[left]])
                        have--;
                    
                    left++;
                }
            }

            return substring;
        }
    }
}