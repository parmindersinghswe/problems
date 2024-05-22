namespace Problems.Library.Medium.ReverseInteger
{
    /// <summary>
    /// Perform the reverse Integer operations
    /// </summary>
    public class ReverseIntegerSolution
    {
        /// <summary>
        /// Return the integer after reversing the digits if reversed number is not in the integer max or min value then returns zero.
        /// </summary>
        /// <param name="x">Input integer value.</param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            long reverse = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                reverse = reverse * 10 + pop;
                if (reverse > Int32.MaxValue || reverse < Int32.MinValue)
                {
                    return 0;
                }
            }
            return (int)reverse;
        }
    }

}
