using System.Collections.Generic;
using System.Linq;

namespace ExpressiveWords
{
    public class Expressive
    {
        public static int ExpressiveWords(string s, string[] words)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var expressive = 0;

            var repeatingCharsInString = RepeatingChars(s);
            foreach (var word in words)
            {
                var repeatingCharInWords = RepeatingChars(word);
                if (IsExpressive(repeatingCharsInString, repeatingCharInWords))
                {
                    expressive++;
                }
            }

            return expressive;
        }

        private static bool IsExpressive(List<KeyValuePair<char, int>> repeatingCharsInString,
                                         List<KeyValuePair<char, int>> repeatingCharInWords)
        {
            if (repeatingCharInWords.Count != repeatingCharsInString.Count)
            {
                return false;
            }

            for (var i = 0; i < repeatingCharInWords.Count; i++)
            {
                var pair = repeatingCharsInString[i];
                var pairInWord = repeatingCharInWords[i];

                if (pair.Key != pairInWord.Key)
                {
                    return false;
                }

                var diff = pair.Value - pairInWord.Value;
                if (!(diff == 0 || diff >= 2))
                    return false;
            }
            
            return true;
        }

        private static List<KeyValuePair<char, int>> RepeatingChars(string s)
        {
            var list = new List<KeyValuePair<char, int>>();
            var repeatingCharsInS = 1;
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    repeatingCharsInS++;
                }
                else
                {
                    var pair = new KeyValuePair<char, int>(s[i], repeatingCharsInS);
                    list.Add(pair);
                    repeatingCharsInS = 1;
                }
            }
            list.Add(new KeyValuePair<char, int>(s.Last(), repeatingCharsInS));
            return list;
        }
    }
}
