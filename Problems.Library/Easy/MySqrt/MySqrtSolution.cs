namespace Problems.Library.Easy.MySqrt
{
    /// <summary>
    /// Solutions for square root problems.
    /// </summary>
    public class MySqrtSolution
    {
        /// <summary>
        /// Returns the nearest integer value of the square root of the given input.
        /// </summary>
        /// <param name="x">The input integer value.</param>
        /// <returns>The nearest integer value of the square root.</returns>
        public int Find(int x)
        {
            if (x <= 1)
            {
                return x;
            }

            int left = 1, right = x / 2;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long square = (long)mid * mid;

                if (square == x)
                {
                    return mid;
                }
                else if (square < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return right;
        }
    }
}
