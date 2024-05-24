namespace Problems.Library.Easy.PlusOne
{
    /// <summary>
    /// Solution to increment an integer represented as an array of digits by one.
    /// </summary>
    public class PlusOneSolution
    {
        /// <summary>
        /// Adds one to the integer value represented by an array of digits and returns the resulting array.
        /// </summary>
        /// <param name="digits">The input array of digits representing an integer.</param>
        /// <returns>An array of digits representing the incremented integer value.</returns>
        public int[] Increment(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }
    }
}
