using System;
using System.Linq;
using System.Text;

namespace MyAtoiNamespace
{
    public class MyAtoiClass
    {
        static readonly int LowerRange = Convert.ToInt32(Math.Pow(-2, 31));
        static readonly int UpperRange = Convert.ToInt32(Math.Pow(2, 31) - 1);
        #region public

        public static int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            // trim leading whitespace
            var modified = s.TrimStart(' ');

            // ignore first char if + or - is present
            var isPositive = ReadValidChars(modified, out var sb);

            var number = GetNumberOfString(sb.ToString(), isPositive);
            return RangeCorrection(number);
        }

        private static bool ReadValidChars(string modified, out StringBuilder sb)
        {
            var isPositive = true;
            if (modified.StartsWith('-'))
            {
                isPositive = false;
                modified = modified.Substring(1);
            }
            else if (modified.StartsWith('+'))
            {
                modified = modified.Substring(1);
            }

            sb = new StringBuilder();
            foreach (var ch in modified)
            {
                if (!char.IsDigit(ch))
                {
                    break;
                }

                sb.Append(ch);
            }

            return isPositive;
        }

        #endregion

        #region private   

        private static int RangeCorrection(double number)
        {
            if (number > UpperRange)
                return UpperRange;

            if (number < LowerRange)
                return LowerRange;
            
            return Convert.ToInt32(number);
        }

        private static double GetNumberOfString(string s, bool positive = true)
        {
            double number;
            try
            {
                var result = double.TryParse(s, out number);
                if (!result)
                {
                    return 0.0;
                }

                if (!positive)
                {
                    number *= (-1);
                }
            }
            catch (Exception)
            {
                return positive ? UpperRange : LowerRange;
            }

            return number;
        }
        
        #endregion
    }
}
