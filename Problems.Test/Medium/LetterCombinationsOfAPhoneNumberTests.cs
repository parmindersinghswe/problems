using Problems.Library.Medium.LetterCombinationsOfAPhoneNumber;

namespace Problems.Test.Medium
{
    public class LetterCombinationsOfAPhoneNumberTests
    {
        public static IEnumerable<object[]> LetterCombinationsTestData()
        {
            yield return new object[] { "23", new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" } };
            yield return new object[] { "", new List<string> { } };
            yield return new object[] { "2", new List<string> { "a", "b", "c" } };
            yield return new object[] { "7", new List<string> { "p", "q", "r", "s" } };
            yield return new object[] { "78", new List<string> { "pt", "pu", "pv", "qt", "qu", "qv", "rt", "ru", "rv", "st", "su", "sv" } };
            yield return new object[] { "234", new List<string> { "adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi" } };
            yield return new object[] { "9", new List<string> { "w", "x", "y", "z" } };
            yield return new object[] { "79", new List<string> { "pw", "px", "py", "pz", "qw", "qx", "qy", "qz", "rw", "rx", "ry", "rz", "sw", "sx", "sy", "sz" } };
            yield return new object[] { "56", new List<string> { "jm", "jn", "jo", "km", "kn", "ko", "lm", "ln", "lo" } };
            yield return new object[] { "8", new List<string> { "t", "u", "v" } };
            yield return new object[] { "345", new List<string> { "dgj", "dgk", "dgl", "dhj", "dhk", "dhl", "dij", "dik", "dil", "egj", "egk", "egl", "ehj", "ehk", "ehl", "eij", "eik", "eil", "fgj", "fgk", "fgl", "fhj", "fhk", "fhl", "fij", "fik", "fil" } };
        }

        [Theory]
        [MemberData(nameof(LetterCombinationsTestData))]
        public void Test_LetterCombinations(string digits, List<string> expected)
        {
            var solution = new LetterCombinationsOfAPhoneNumberSolution();
            IList<string> result = solution.LetterCombinations(digits);
            Assert.Equal(expected, result);
        }
    }
}
