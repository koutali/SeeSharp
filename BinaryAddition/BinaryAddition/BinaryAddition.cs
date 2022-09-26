using System;
using System.Text;

namespace BinaryAddition
{
    public class BinaryAddition
    {
        public static string AddBinary(string a, string b)
        {
            if (a == null)
                throw new ArgumentException(nameof(a));

            if (b == null)
                throw new ArgumentException(nameof(b));

            var sb = new StringBuilder();
            bool carry = false;

            // determine short and long strings
            var length = a.Length;
            var longerLength = b.Length;

            if (b.Length < a.Length)
            {
                length = b.Length;
                longerLength = a.Length;
            }

            a = Reverse(a);
            b = Reverse(b);

            // start adding
            for (var i = 0; i < length; i++)
            {
                // both digits 0
                if (a[i] == '0' && b[i] == '0')
                {
                    if (!carry)
                        sb.Append('0');
                    else
                    {
                        sb.Append('1');
                        carry = false;
                    }
                }

                // one of the digits are one
                if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
                {
                    if (!carry)
                        sb.Append('1');
                    else
                    {
                        sb.Append('0');
                    }
                }

                // both digits are one
                if (a[i] == '1' && b[i] == '1')
                {
                    if (!carry)
                    {
                        sb.Append('0');
                        carry = true;
                    }
                    else
                    {
                        sb.Append(1);
                        carry = true;
                    }
                }
            }

            // process the remaining elements from the longer string
            var remainingString = b;
            if (longerLength == a.Length)
                remainingString = a;

            for (var i = length; i < longerLength; i++)
            {
                if (!carry && remainingString[i] == '0')
                    sb.Append('0');

                if (carry && remainingString[i] == '0')
                {
                    carry = false;
                    sb.Append('1');
                }

                if (!carry && remainingString[i] == '1')
                    sb.Append('1');

                if (carry && remainingString[i] == '1')
                    sb.Append('0');
            }

            if (carry)
                sb.Append('1');


            return Reverse(sb.ToString());
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
