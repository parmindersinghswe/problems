namespace Problems.Library.Medium.StringToInteger
{
    /// <summary>
    /// Convert the String To Integers
    /// </summary>
    public class StringToIntegerSolution
    {
        /// <summary>
        /// return the first integer value from the string ignoring any leading spaces and considering an optional leading sign character.
        /// </summary>
        /// <param name="s">Input String Value</param>
        /// <returns></returns>
        public int MyAtoi(string s)
        {
            int i = 0;
            int returnValue = 0;
            int totalChars = s.Length;
            int sign = 1;
            while (i < totalChars && s[i] == ' ')
            {
                i++;
            }
            if (i < totalChars)
            {
                if (s[i] == '-')
                {
                    sign = -1;
                    i++;
                }
                else if (s[i] == '+')
                {
                    i++;
                }
                while (i < totalChars && s[i] >= 48 && s[i] <= 57)
                {
                    if (returnValue == 0)
                    {
                        returnValue = CharToInt(s[i]);
                    }
                    else
                    {
                        int newDigit = CharToInt(s[i]);
                        if (returnValue > (Int32.MaxValue - newDigit) / 10)
                        {
                            return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                        }
                        returnValue = (returnValue * 10) + newDigit;
                    }
                    i++;
                }
            }
            returnValue *= sign;
            return returnValue;
        }
        private int CharToInt(char ch)
        {
            return ch - 48;
        }
    }
}
