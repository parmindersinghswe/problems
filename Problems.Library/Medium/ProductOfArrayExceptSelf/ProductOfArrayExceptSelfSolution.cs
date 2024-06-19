namespace Problems.Library.Medium.ProductOfArrayExceptSelf
{
    /// <summary>
    /// Solution for the "Product of Array Except Self" problem.
    /// This class provides a method to calculate the product of an array except for the current element without using division.
    /// </summary>
    public class ProductOfArrayExceptSelfSolution
    {
        /// <summary>
        /// Calculates the product of the array except for the current element for each element in the input array.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>An array where each element is the product of all the elements of the input array except the current element.</returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] result = new int[length];
            int product = 1;
            int zeroCount = 0;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                    if (zeroCount > 1)
                    {
                        // If there are more than one zero, all elements in the result are zero
                        for (int j = 0; j < length; j++)
                        {
                            result[j] = 0;
                        }
                        return result;
                    }
                }
                else
                {
                    product *= nums[i];
                }
            }

            for (int i = 0; i < length; i++)
            {
                if (zeroCount == 1)
                {
                    result[i] = nums[i] == 0 ? product : 0;
                }
                else
                {
                    result[i] = product / nums[i];
                }
            }

            return result;
        }
    }
}
