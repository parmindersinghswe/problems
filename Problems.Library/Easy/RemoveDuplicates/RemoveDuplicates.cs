namespace Problems.Library.Easy.RemoveDuplicates
{
    public class RemoveDuplicates
    {
        public int Remove(int[] nums)
        {
            // Initialize 'prev' to a value that is not present in the array to start the comparison
            int prev = nums[0] - 1;

            // 'currentIndex' keeps track of the position to place the next unique element
            int currentIndex = 0;

            // Loop through each element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // If the current element is not equal to 'prev', it's a unique element
                if (prev != nums[i])
                {
                    // Update 'prev' to the current element
                    prev = nums[i];

                    // Place the unique element at the current index
                    nums[currentIndex++] = prev;
                }
            }

            // Return the count of unique elements
            return currentIndex;
        }
    }
}
