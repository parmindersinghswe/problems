namespace Problems.Library.Easy.RemoveElement
{
    public class RemoveElement
    {
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
