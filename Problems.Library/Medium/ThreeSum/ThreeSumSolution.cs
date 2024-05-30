namespace Problems.Library.Medium.ThreeSum
{
    /// <summary>
    /// Solution to find all unique triplets in the array which give the sum of zero.
    /// </summary>
    public class ThreeSumSolution
    {
        /// <summary>
        /// Finds all unique triplets in the array which give the sum of zero.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>A list of lists, where each list contains three integers that sum up to zero.</returns>
        public IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }
    }
}
