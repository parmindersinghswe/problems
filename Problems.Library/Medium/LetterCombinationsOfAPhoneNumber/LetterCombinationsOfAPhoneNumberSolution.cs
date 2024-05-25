using System.Text;

namespace Problems.Library.Medium.LetterCombinationsOfAPhoneNumber
{
    /// <summary>
    /// Solution to generate all possible letter combinations from a phone number.
    /// </summary>
    public class LetterCombinationsOfAPhoneNumberSolution
    {
        private readonly Dictionary<char, string> digitsToCharacters = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        /// <summary>
        /// Generates all possible letter combinations that the number could represent.
        /// </summary>
        /// <param name="digits">A string containing digits from 2-9.</param>
        /// <returns>A list of all possible letter combinations.</returns>
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (!string.IsNullOrEmpty(digits))
            {
                StringBuilder currentCombination = new StringBuilder();
                GenerateCombinations(currentCombination, result, digits, 0);
            }

            return result;
        }

        /// <summary>
        /// Recursively generates all possible letter combinations.
        /// </summary>
        /// <param name="currentCombination">The current combination being built.</param>
        /// <param name="result">The list to store the generated combinations.</param>
        /// <param name="digits">The input string of digits.</param>
        /// <param name="index">The current index in the digits string.</param>
        private void GenerateCombinations(StringBuilder currentCombination, IList<string> result, string digits, int index)
        {
            if (index >= digits.Length)
            {
                result.Add(currentCombination.ToString());
                return;
            }

            char currentDigit = digits[index];
            if (digitsToCharacters.ContainsKey(currentDigit))
            {
                string letters = digitsToCharacters[currentDigit];
                foreach (char letter in letters)
                {
                    currentCombination.Append(letter);
                    GenerateCombinations(currentCombination, result, digits, index + 1);
                    currentCombination.Length--;
                }
            }
        }
    }
}
