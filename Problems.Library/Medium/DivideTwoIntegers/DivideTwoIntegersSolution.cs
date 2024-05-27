namespace Problems.Library.Medium.DivideTwoIntegers
{
    /// <summary>
    /// Solution to divide two integers without using multiplication, division, and mod operator.
    /// </summary>
    public class DivideTwoIntegersSolution
    {
        /// <summary>
        /// Divides two integers and returns the quotient.
        /// </summary>
        /// <param name="dividend">The number to be divided.</param>
        /// <param name="divisor">The number by which to divide.</param>
        /// <returns>The quotient of the division.</returns>
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;

            int sign = (dividend < 0) == (divisor < 0) ? 1 : -1;
            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);
            long result = 0;

            while (absDividend >= absDivisor)
            {
                long temp = absDivisor, increment = 1;
                while ((temp << 1) <= absDividend)
                {
                    temp <<= 1;
                    increment <<= 1;
                }
                absDividend -= temp;
                result += increment;
            }
            result *= sign;
            return (int)result;
        }
    }
}
