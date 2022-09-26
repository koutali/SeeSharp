using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace GroupAnagrams
{
    public class Anagrams
    {
        private static readonly Dictionary<char, int> LetterToPrime = new()
        {
            { 'a', 2 }, { 'b', 3 }, { 'c', 5 }, { 'd', 7 }, { 'e', 11 }, { 'f', 13 }, { 'g', 17 },
            { 'h', 19 }, { 'i', 23 }, { 'j', 29 }, { 'k', 31 }, { 'l', 37 }, { 'm', 41 },
            { 'n', 43 }, { 'o', 47 }, { 'p', 53 }, { 'q', 59 }, { 'r', 61 }, { 's', 67 },
            { 't', 71 }, { 'u', 73 }, { 'v', 79 }, { 'w', 83 }, { 'x', 89 }, { 'y', 97 }, { 'z', 101 }
        };

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagrams = FindAnagrams(strs);
            return CreateAnagramGroups(anagrams);
        }

        private static IList<IList<string>> CreateAnagramGroups(Dictionary<BigInteger, List<string>> anagrams)
        {
            var anagramsList = new List<IList<string>>();
            foreach (var anagram in anagrams)
            {
                anagramsList.Add(anagram.Value);
            }

            return anagramsList;
        }

        private static Dictionary<BigInteger, List<string>> FindAnagrams(string[] strs)
        {
            var anagrams = new Dictionary<BigInteger, List<string>>();
            foreach (var str in strs)
            {
                var lowerCase = str.ToLower();
                var hash = FindHash(lowerCase);

                if (anagrams.ContainsKey(hash))
                {
                    anagrams[hash].Add(str);
                    anagrams[hash] = anagrams[hash].OrderBy(x => x).ToList();
                }
                else
                {
                    anagrams.Add(hash, new List<string> { str });
                }
            }

            return anagrams;
        }

        private static BigInteger FindHash(string lowerCase)
        {
            var hash = new BigInteger(1);
            foreach (var t in lowerCase)
            {
                hash *= LetterToPrime[t];
            }

            return hash;
        }
    }
}
