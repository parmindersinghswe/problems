namespace Problems.Library.Medium.ReverseInteger
{
    /// <summary>
    /// Solution to perform reverse integer operations.
    /// </summary>
    public class ReverseIntegerSolution
    {
        /// <summary>
        /// Reverses the digits of an integer. If the reversed integer overflows, returns zero.
        /// </summary>
        /// <param name="x">The input integer value.</param>
        /// <returns>The reversed integer value, or zero if it overflows.</returns>
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
