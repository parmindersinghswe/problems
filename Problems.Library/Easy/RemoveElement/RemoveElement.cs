namespace Problems.Library.Easy.RemoveElement
{
    /// <summary>
    /// Remove all the occurences of given input value
    /// </summary>
    public class RemoveElement
    {
        /// <summary>
        /// Remove the given input value and set the all other values to the start of the array and return the number of remaining items.
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="val">Target value to remove from array</param>
        /// <returns></returns>
        public int Remove(int[] nums, int val)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current++] = nums[i];
                }
            }
            return current;
        }
    }
}
