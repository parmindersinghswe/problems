namespace Problems.Library.Easy.AddBinary
{
    /// <summary>
    /// To add two binary string values
    /// </summary>
    public class AddBinarySolution
    {
        /// <summary>
        /// Adds and return addition of two binary numbers represented in string
        /// </summary>
        /// <param name="a">first binary input</param>
        /// <param name="b">second binary input</param>
        /// <returns></returns>
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
