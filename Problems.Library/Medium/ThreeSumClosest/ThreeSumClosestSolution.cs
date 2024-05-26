namespace Problems.Library.Medium.ThreeSumClosest
{
    /// <summary>
    /// Solution to find the sum of three integers in an array that is closest to a given target value.
    /// </summary>
    public class ThreeSumClosestSolution
    {
        /// <summary>
        /// Finds the sum of three integers in the array that is closest to the target value.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <param name="target">The target sum value.</param>
        /// <returns>The sum of three integers that is closest to the target value.</returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];
                    if (currentSum == target)
                    {
                        return currentSum;
                    }

                    if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = currentSum;
                    }

                    if (currentSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return closestSum;
        }
    }
}