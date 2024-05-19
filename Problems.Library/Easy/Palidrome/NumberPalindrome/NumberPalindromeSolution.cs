namespace Problems.Library.Easy.Palidrom.NumberPalidrom
{
    /// <summary>
    /// To check if given integer is valid palidrome or not.
    /// </summary>
    public class NumberPalindromeSolution
    {
        /// <summary>
        /// Return true if the input string is valid palirome otherwise returns false.
        /// </summary>
        /// <param name="x">Given input integer value.</param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0 && x != 0)
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