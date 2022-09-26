using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerToEnglish
{
    public class IntToEnglish
    {
        #region public
        public static string NumberToWords(int num)
        {
            if (num < 0)
                throw new ArgumentException(nameof(num));

            return ParseNumber(num);
        }

        #endregion

        #region private
        private static string ParseNumber(int num)
        {
            if (num == 0)
                return "Zero";

            var groups = GroupNumber(num);
            var endings = CreateEndings(groups.Count - 1);

            var sb = new StringBuilder();
            for (var i = 0; i < groups.Count; i++)
            {
                var group = groups.ElementAt(i);
                if (group == 0)
                    continue;

                sb.Append(ThreeDigitToString(@group));
                sb.Append(' ');

                sb.Append(GetEnding(i, endings));
                sb.Append(' ');
            }

            var toReturn = sb.ToString();
            toReturn = toReturn.TrimEnd(' ');

            return toReturn;
        }

        private static List<string> CreateEndings(int groupsCount)
        {
            var endings = new List<string>
            {
                string.Empty
            };

            if (groupsCount >= 1)
                endings.Add("Thousand");
            if (groupsCount >= 2)
                endings.Add("Million");
            if (groupsCount >= 3)
                endings.Add("Billion");

            endings.Reverse();
            return endings;
        }

        private static List<int> GroupNumber(int num)
        {
            var groups = new List<int>();
            while (num >= 1000)
            {
                var remainder = num % 1000;
                groups.Add(remainder);
                num /= 1000;
            }

            groups.Add(num);
            groups.Reverse();
            return groups;
        }

        private static string GetEnding(int index, IEnumerable<string> endings)
        {
            return endings.ElementAt(index);
        }

        private static string ThreeDigitToString(int num)
        {
            var sb = new StringBuilder();

            if (num > 99 && num < 1000)
            {
                var first = num / 100;
                num %= 100;

                sb.Append(DigitToString(first));
                sb.Append(' ');
                sb.Append("Hundred");

                if (num == 0)
                {
                    return sb.ToString();
                }

                sb.Append(' ');
            }

            switch (num)
            {
                case >= 10 and < 20:
                    sb.Append(TwoDigitToString(num));
                    return sb.ToString();

                case >= 20 and < 100:
                    var second = num / 10;
                    num %= 10;
                    sb.Append(TwoDigitToString(second));

                    if (num == 0)
                    {
                        return sb.ToString();
                    }

                    sb.Append(' ');
                    break;
            }

            sb.Append(DigitToString(num));
            return sb.ToString();
        }

        private static string DigitToString(int digit)
        {
            return digit switch
            {
                0 => "Zero",
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => string.Empty
            };
        }

        private static string TwoDigitToString(int num)
        {
            return num switch
            {
                10 => "Ten",
                11 => "Eleven",
                12 => "Twelve",
                13 => "Thirteen",
                14 => "Fourteen",
                15 => "Fifteen",
                16 => "Sixteen",
                17 => "Seventeen",
                18 => "Eighteen",
                19 => "Nineteen",
                { } n when (n >= 2 && n < 3) => "Twenty",
                { } n when (n >= 3 && n < 4) => "Thirty",
                { } n when (n >= 4 && n < 5) => "Forty",
                { } n when (n >= 5 && n < 6) => "Fifty",
                { } n when (n >= 6 && n < 7) => "Sixty",
                { } n when (n >= 7 && n < 8) => "Seventy",
                { } n when (n >= 8 && n < 9) => "Eighty",
                { } n when (n == 9) => "Ninety",
                _ => string.Empty
            };
        }
        #endregion
    }
}
