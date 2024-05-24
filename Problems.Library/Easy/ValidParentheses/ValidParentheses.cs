namespace Problems.Library.Easy.ValidParentheses
{
    /// <summary>
    /// Solution to check if the given parentheses are valid.
    /// </summary>
    public class ValidParentheses
    {
        /// <summary>
        /// Helper method to check if a character is an opening bracket.
        /// </summary>
        /// <param name="br">Input parentheses character.</param>
        /// <returns>True if the character is an opening bracket; otherwise, false.</returns>
        private bool IsOpen(char br)
        {
            return br == '(' || br == '{' || br == '[';
        }

        /// <summary>
        /// Determines if a given string of parentheses is valid.
        /// </summary>
        /// <param name="s">The input string containing the sequence of parentheses.</param>
        /// <returns>True if the parentheses are valid; otherwise, false.</returns>
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0)
                {
                    if (IsOpen(s[i]))
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        if ((s[i] == ')' && stack.Peek() == '(') ||
                            (s[i] == '}' && stack.Peek() == '{') ||
                            (s[i] == ']' && stack.Peek() == '['))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(s[i]);
                        }
                    }
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;
        }
    }
}
