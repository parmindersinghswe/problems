namespace Problems.Library.Easy.FindIndexOfFirstOccurence
{
    public class FindIndexOfFirstOccurenceSolution
    {
        public int Find(string haystack, string needle)
        {
            int current = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                int currentFrom = i;
                while (current < needle.Length && currentFrom < haystack.Length && needle[current] == haystack[currentFrom])
                {
                    currentFrom++;
                    current++;
                }
                if (current == needle.Length)
                {
                    return i;
                }
                current = 0;
            }
            if (haystack != null && needle != null && needle == "")
            {
                return 0;
            }
            return -1;
        }
    }
}
