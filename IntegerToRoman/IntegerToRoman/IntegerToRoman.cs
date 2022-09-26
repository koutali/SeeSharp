using System.Text;

namespace IntegerToRoman
{
    public class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            var sb = new StringBuilder();

            if (num >= 1000)
            {
                var rem = num / 1000;
                sb.Append(GetFourthRomanDigit(rem));
                num %= 1000;
            }

            if (num >= 100)
            {
                var rem = num / 100;
                sb.Append(GetThirdRomanDigit(rem));
                num %= 100;
            }

            if (num >= 10)
            {
                var rem = num / 10;
                sb.Append(GetSecondRomanDigit(rem));
                num %= 10;
            }

            sb.Append(GetFirstRomanDigit(num));
            return sb.ToString();
        }

        private static string GetFirstRomanDigit(int digit)
        {
            return digit switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => string.Empty
            };
        }

        private static string GetSecondRomanDigit(int digit)
        {
            return digit switch
            {
                1 => "X",
                2 => "XX",
                3 => "XXX",
                4 => "XL",
                5 => "L",
                6 => "LX",
                7 => "LXX",
                8 => "LXXX",
                9 => "XC",
                _ => string.Empty
            };
        }

        private static string GetThirdRomanDigit(int digit)
        {
            return digit switch
            {
                1 => "C",
                2 => "CC",
                3 => "CCC",
                4 => "CD",
                5 => "D",
                6 => "DC",
                7 => "DCC",
                8 => "DCCC",
                9 => "CM",
                _ => string.Empty
            };
        }

        private static string GetFourthRomanDigit(int digit)
        {
            return digit switch
            {
                1 => "M",
                2 => "MM",
                3 => "MMM",
                _ => string.Empty
            };
        }
    }
}
