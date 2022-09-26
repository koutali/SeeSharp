using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostCommonWords
{
    public class CommonWords
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            if (string.IsNullOrEmpty(paragraph))
            {
                throw new ArgumentException(nameof(paragraph));
            }
            paragraph = AddSpacingRemovePunctuationAndMakeLowercase(paragraph);

            if (!paragraph.Contains(' '))
            {
                return RemoveBannedWordsFromString(paragraph, banned); 
            }

            return ProcessParagraphWithSpace(paragraph, banned);
        }

        private static string ProcessParagraphWithSpace(string paragraph, string[] banned)
        {
            var paragraphSplit = paragraph.Split(' ');
            paragraphSplit = paragraphSplit.OrderBy(x => x).ToArray();

            var occurence = CreateOccurence(paragraphSplit);
            RemoveBannedWords(banned, occurence);

            var orderPairs = occurence.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToArray();
            return orderPairs[0].Key;
        }

        private static string RemoveBannedWordsFromString(string paragraph, string[] banned)
        {
            foreach (var word in banned)
            {
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                paragraph = paragraph.Replace(word, "");
            }

            return paragraph;
        }

        private static void RemoveBannedWords(string[] banned, Dictionary<string, int> occurence)
        {
            occurence.Remove(" ");
            occurence.Remove("");
            foreach (var word in banned)
            {
                if (occurence.ContainsKey(word))
                {
                    occurence.Remove(word);
                }
            }
        }

        private static Dictionary<string, int> CreateOccurence(string[] paragraphSplit)
        {
            var occurence = new Dictionary<string, int>();
            var count = 1;
            for (var i = 0; i < paragraphSplit.Length -1; i++)
            {
                if (paragraphSplit[i].Equals(paragraphSplit[i + 1]))
                {
                    count++;
                }
                else
                {
                    occurence.Add(paragraphSplit[i], count);
                    count = 1;
                }
            }

            if (occurence.ContainsKey(paragraphSplit[^1]))
            {
                occurence[paragraphSplit[^1]]++;
            }
            else
            {
                occurence.Add(paragraphSplit[^1], count);
            }

            return occurence;
        }

        public static string AddSpacingRemovePunctuationAndMakeLowercase(string paragraph)
        {
            var sb = new StringBuilder();
            if (!char.IsPunctuation(paragraph[0]))
            {
                sb.Append(paragraph[0]);
            }

            for (var i = 1; i < paragraph.Length - 1; i++)
            {
                if (char.IsLetterOrDigit(paragraph[i]) || paragraph[i] == ' ')
                {
                    sb.Append(paragraph[i]);
                }

                else if (char.IsPunctuation(paragraph[i]))
                {
                    if (paragraph[i - 1] != ' ')
                    {
                        sb.Append(' ');
                    }

                    if (paragraph[i + 1] != ' ')
                    {
                        sb.Append(' ');
                    }
                }
            }

            if (!char.IsPunctuation(paragraph[^1]))
            {
                sb.Append(paragraph[^1]);
            }

            return sb.ToString().ToLower();
        }
    }
}
