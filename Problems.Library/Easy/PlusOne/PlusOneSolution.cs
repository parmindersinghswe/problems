namespace Problems.Library.Easy.PlusOne
{
    /// <summary>
    /// Add One to the intger value represented with the array of digits
    /// </summary>
    public class PlusOneSolution
    {
        /// <summary>
        /// Return the array of integers by adding 1 to the array that represents the one integer value with array of digits.
        /// </summary>
        /// <param name="digits">Input of digits.</param>
        /// <returns></returns>
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
