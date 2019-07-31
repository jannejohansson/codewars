using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars
{
    public class Kata
    {
        public static int SquareEveryDigit(int n)
        {
            var result = "";
            var digits = n.ToString();
            for (int i = 0; i < digits.Length; i++)
            {
                //result += digits[i] * digits[i]; // Will use char value of the digit.
                result += Convert.ToInt32(digits.Substring(i, 1)) * Convert.ToInt32(digits.Substring(i, 1));
            }
            return Convert.ToInt32(result);
        }

        public static long BuildAPileOfCubes(long m)
        {
            var n = 1;
            long volume = 0;

            while (volume < m)
            {
                volume += n * n * n;
                n++;
            }

            return (volume == m) ? n - 1 : -1;
        }
    }
}
