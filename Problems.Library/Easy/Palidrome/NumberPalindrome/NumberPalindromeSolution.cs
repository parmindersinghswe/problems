namespace Problems.Library.Easy.Palindrome.NumberPalindrome
{
    /// <summary>
    /// Solution to check if a given integer is a palindrome.
    /// </summary>
    public class NumberPalindromeSolution
    {
        /// <summary>
        /// Returns true if the input integer is a palindrome; otherwise, returns false.
        /// </summary>
        /// <param name="x">The input integer.</param>
        /// <returns>True if the input integer is a palindrome; otherwise, false.</returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int reversedHalf = 0;
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }
            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
}
