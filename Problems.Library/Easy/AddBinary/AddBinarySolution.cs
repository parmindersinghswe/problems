namespace Problems.Library.Easy.AddBinary
{
    public class AddBinarySolution
    {
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
