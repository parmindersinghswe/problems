namespace Problems.Library.Medium.FourSum
{
    /// <summary>
    /// Solution to find all unique quadruplets in the array which give the sum of the target value.
    /// </summary>
    public class FourSumSolution
    {
        /// <summary>
        /// Finds all unique quadruplets in the array which gives the sum of the target value.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <param name="target">The target sum value.</param>
        /// <returns>A list of lists, where each list contains four integers that sum up to the target value.</returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            int len = nums.Length;
            long sum;
            int left;
            int right;
            IList<IList<int>> result = new List<IList<int>>();
            HashSet<string> seen = new HashSet<string>();
            for (int i = 0; i < len - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < len - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    left = j + 1;
                    right = len - 1;

                    while (left < right)
                    {
                        sum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];

                        if (sum == target)
                        {
                            var quad = new List<int> { nums[i], nums[j], nums[left], nums[right] }.OrderBy(x=> x).ToList();

                            string key = string.Join(",", quad);
                            if (!seen.Contains(key))
                            {
                                result.Add(quad);
                                seen.Add(key);
                            }
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }
            return result;
        }
    }
}
