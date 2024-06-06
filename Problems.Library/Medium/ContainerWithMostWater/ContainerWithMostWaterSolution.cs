namespace Problems.Library.Medium.MaxArea
{
    /// <summary>
    /// Class to solve the problem of finding the maximum area of water that can be contained.
    /// </summary>
    public class ContainerWithMostWaterSolution
    {
        /// <summary>
        /// Finds the maximum area of water that can be contained by the given heights.
        /// </summary>
        /// <param name="height">An array of integers representing the heights.</param>
        /// <returns>The maximum area of water that can be contained.</returns>
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int currentWidth = right - left;
                int currentArea = currentHeight * currentWidth;
                max = Math.Max(max, currentArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return max;
        }
    }
}
