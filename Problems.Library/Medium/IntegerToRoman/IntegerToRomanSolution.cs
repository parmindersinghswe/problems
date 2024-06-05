using System.Text;

namespace Problems.Library.Medium.IntegerToRoman
{
    /// <summary>
    /// Class to convert an integer to its Roman numeral representation.
    /// </summary>
    public class IntegerToRomanSolution
    {
        /// <summary>
        /// Array of tuples that map integer values to their corresponding Roman numeral representations.
        /// </summary>
        private static readonly (int value, string numeral)[] RomanNumerals = new (int, string)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        /// <summary>
        /// Converts an integer to its Roman numeral representation.
        /// </summary>
        /// <param name="num">The integer to convert.</param>
        /// <returns>A string representing the Roman numeral of the given integer.</returns>
        public string IntToRoman(int num)
        {
            StringBuilder roman = new StringBuilder();
            foreach (var (value, numeral) in RomanNumerals)
            {
                while (num >= value)
                {
                    roman.Append(numeral);
                    num -= value;
                }
            }
            return roman.ToString();
        }
    }
}
