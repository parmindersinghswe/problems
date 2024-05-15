﻿namespace Problems.ValidParentheses
{
    internal class ValidParentheses
    {
        // Helper method to check if a character is an opening bracket
        private bool isOpen(char br)
        {
            return br == '(' || br == '{' || br == '[';
        }

        // Main method to determine if a given string of brackets is valid
        public bool IsValid(string s)
        {
            // Stack to keep track of opening brackets
            Stack<char> stk1 = new Stack<char>();

            // Iterate through each character in the string
            for (int i = 0; i < s.Length; i++)
            {
                // Check if the stack is not empty
                if (stk1.Count > 0)
                {
                    // If the current character is an opening bracket, push it onto the stack
                    if (isOpen(s[i]))
                    {
                        stk1.Push(s[i]);
                    }
                    else
                    {
                        // If the current character is a closing bracket, check if it matches the top of the stack
                        if ((s[i] == ')' && stk1.Peek() == '(') || (s[i] == '}' && stk1.Peek() == '{') || (s[i] == ']' && stk1.Peek() == '['))
                        {
                            // If it matches, pop the top of the stack
                            stk1.Pop();
                        }
                        else
                        {
                            // If it doesn't match, push the closing bracket onto the stack
                            stk1.Push(s[i]);
                        }
                    }
                }
                else
                {
                    // If the stack is empty, push the current character onto the stack
                    stk1.Push(s[i]);
                }
            }

            // If the stack is empty at the end, all brackets were matched correctly
            return stk1.Count == 0;
        }
    }

}
