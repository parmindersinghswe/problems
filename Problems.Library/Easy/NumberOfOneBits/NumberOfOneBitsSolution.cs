namespace Problems.Library.Easy.NumberOfOneBits
{
    /// <summary>
    /// Solution to count the number of 1 bits in an integer.
    /// </summary>
    public class NumberOfOneBitsSolution
    {
        /// <summary>
        /// Counts the number of 1 bits in the binary representation of the given integer.
        /// </summary>
        /// <param name="n">The integer to count the 1 bits in.</param>
        /// <returns>The number of 1 bits in the binary representation of the integer.</returns>
        public uint HammingWeight(uint n)
        {
            uint count = 0;
            while (n != 0)
            {
                count += (n & 1);
                n >>= 1;
            }
            return count;
        }
    }
}
