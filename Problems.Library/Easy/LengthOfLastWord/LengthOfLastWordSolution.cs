namespace Problems.Library.Easy.LengthOfLastWord
{
    public class LengthOfLastWordSolution
    {
        public int Length(string s)
        {
            int i = s.Length - 1;
            int length = 0;
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}
