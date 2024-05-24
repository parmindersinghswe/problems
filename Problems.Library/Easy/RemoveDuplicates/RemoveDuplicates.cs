using Problems.Library.Models;

namespace Problems.Library.Easy.RemoveDuplicates
{
    /// <summary>
    /// Solutions for removing duplicate values.
    /// </summary>
    public class RemoveDuplicates
    {
        /// <summary>
        /// Removes duplicates from a sorted linked list and returns the head of the modified list.
        /// </summary>
        /// <param name="head">The head node of the sorted linked list.</param>
        /// <returns>The head node of the linked list after removing duplicates.</returns>
        public ListNode? Remove(ListNode? head)
        {
            ListNode? ptr = head;

            while (ptr != null && ptr.next != null)
            {
                if (ptr.val == ptr.next.val)
                {
                    ptr.next = ptr.next.next;
                }
                else
                {
                    ptr = ptr.next;
                }
            }
            return head;
        }

        /// <summary>
        /// Removes duplicates from an array and returns the number of unique elements.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>The number of unique elements in the array after removing duplicates.</returns>
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
