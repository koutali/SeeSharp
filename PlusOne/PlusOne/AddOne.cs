using System.Collections.Generic;
using System.Linq;

namespace PlusOne
{
    public class AddOne
    {
        public static int[] PlusOne(int[] digits)
        {
            var carry = 0;
            digits[^1] += 1;

            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (carry == 1)
                {
                    digits[i] += carry;
                    carry = 0;
                }

                if (digits[i] < 10) 
                    continue;

                digits[i] %= 10;
                carry = 1;
            }

            var listOfDigits = new List<int>();
            if (carry == 1)
            {
                listOfDigits.Add(1);
            }
            listOfDigits.AddRange(digits);
            return listOfDigits.ToArray();
        }
    }
}
