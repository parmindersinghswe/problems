using System.Text;

namespace Problems.Library.Medium.GenerateParentheses
{
    /// <summary>
    /// Solution to generate all combinations of well-formed parentheses.
    /// </summary>
    public class GenerateParenthesesSolution
    {
        /// <summary>
        /// Generates all combinations of well-formed parentheses for a given number of pairs.
        /// </summary>
        /// <param name="n">The number of pairs of parentheses.</param>
        /// <returns>A list of strings, each representing a valid combination of parentheses.</returns>
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> combinations = new List<string>();
            Paranthesis(combinations, new StringBuilder(), n, n * 2, 0, 0);
            return combinations;
        }

        /// <summary>
        /// Helper method to generate parentheses combinations recursively.
        /// </summary>
        /// <param name="combinations">The list to store valid combinations.</param>
        /// <param name="combination">The current combination being built.</param>
        /// <param name="n">The number of pairs of parentheses.</param>
        /// <param name="m">The total number of parentheses (2 * n).</param>
        /// <param name="lc">The current count of left parentheses.</param>
        /// <param name="rc">The current count of right parentheses.</param>
        private void Paranthesis(IList<string> combinations, StringBuilder combination, int n, int m, int lc, int rc)
        {
            if (combination.Length == m)
            {
                combinations.Add(combination.ToString());
                return;
            }

            if (lc < n)
            {
                combination.Append('(');
                Paranthesis(combinations, combination, n, m, lc + 1, rc);
                combination.Length--;
            }

            if (rc < lc)
            {
                combination.Append(')');
                Paranthesis(combinations, combination, n, m, lc, rc + 1);
                combination.Length--;
            }
        }
    }

}
