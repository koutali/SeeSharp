using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterCombinations
{

    public class Combinations
    {
        private Dictionary<char, List<string>> hashMap;

        public Combinations()
        {
            hashMap = new Dictionary<char, List<string>>
            {
                {'2', new List<string>() {"a", "b", "c"}},
                {'3', new List<string>() {"d", "e", "f"}},
                {'4', new List<string>() {"g", "h", "i"}},
                {'5', new List<string>() {"j", "k", "l"}},
                {'6', new List<string>() {"m", "n", "o"}},
                {'7', new List<string>() {"p", "q", "r"}},
                {'8', new List<string>() {"t", "u", "v"}},
                {'9', new List<string>() {"w", "y", "x", "z"}}
            };
        }

        public IList<string> LetterCombinations(string digits)
        {
            if (digits == null)
            {
                throw new ArgumentException(nameof(digits));
            }

            var list = new List<string>();
            if (digits.Length == 0)
            {
                return list;
            }

            if (!hashMap.ContainsKey(digits[0]))
                throw new ArgumentException(nameof(digits));

            if (digits.Length == 1)
            {
                return hashMap[digits[0]];
            }

            var first = digits[0];
            list = hashMap[first];

            for (var i = 1; i < digits.Length; i++)
            {
                var second = digits[i];
                var listTwo = hashMap[second];
                list = MergeLists(list, listTwo);
            }

            return list;
        }

        private static List<string> MergeLists(IEnumerable<string> listOne, IReadOnlyCollection<string> listTwo)
        {
            var merged = new List<string>();
            foreach (var first in listOne)
            {
                merged.AddRange(listTwo.Select(second => first + second));
            }

            return merged;
        }
    }
}
