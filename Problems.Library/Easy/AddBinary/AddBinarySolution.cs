namespace Problems.Library.Easy.AddBinary
{
    /// <summary>
    /// Solution for adding two binary strings.
    /// </summary>
    public class AddBinarySolution
    {
        /// <summary>
        /// Adds two binary numbers represented as strings and returns the sum.
        /// </summary>
        /// <param name="a">The first binary string.</param>
        /// <param name="b">The second binary string.</param>
        /// <returns>The binary sum as a string.</returns>
        public string AddBinary(string a, string b)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            int carry = 0;

            while (aIndex >= 0 || bIndex >= 0 || carry > 0)
            {
                int sum = carry;

                if (aIndex >= 0)
                {
                    sum += a[aIndex--] - '0';
                }

                if (bIndex >= 0)
                {
                    sum += b[bIndex--] - '0';
                }

                result.Insert(0, sum % 2);
                carry = sum / 2;
            }

            return result.ToString();
        }
    }
}
