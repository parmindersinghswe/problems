namespace Problems.Library.Medium.HIndex
{
    /// <summary>
    /// Solution for calculating the H-Index of a researcher based on their citation count.
    /// </summary>
    public class HIndexSolution
    {
        /// <summary>
        /// Calculates the H-Index for a given array of citation counts.
        /// </summary>
        /// <param name="citations">An array of integers representing the citation counts of a researcher's publications.</param>
        /// <returns>The H-Index of the researcher.</returns>
        public int HIndex(int[] citations)
        {
            List<int> lst = citations.OrderByDescending(x => x).ToList();
            int h = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] >= i + 1)
                {
                    h = i + 1;
                }
                else
                {
                    break;
                }
            }
            return h;
        }
    }
}
