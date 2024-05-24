using Problems.Library.Medium.GenerateParentheses;
namespace Problems.Test.Medium
{
    public class GenerateParenthesesSolutionTests
    {
        public static IEnumerable<object[]> GenerateParenthesisTestData()
        {
            yield return new object[] { 1, new List<string> { "()" } };
            yield return new object[] { 2, new List<string> { "(())", "()()" } };
            yield return new object[] { 3, new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" } };
            yield return new object[] { 0, new List<string> { "" } };
            yield return new object[] { 4, new List<string> { "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()" } };
            yield return new object[] { 5, new List<string> { "((((()))))", "(((()())))", "(((())()))", "(((()))())", "(((())))()", "((()(())))", "((()()()))", "((()())())", "((()()))()", "((())(()))", "((())()())", "((())())()", "((()))(())", "((()))()()", "(()((())))", "(()(()()))", "(()(())())", "(()(()))()", "(()()(()))", "(()()()())", "(()()())()", "(()())(())", "(()())()()", "(())((()))", "(())(()())", "(())(())()", "(())()(())", "(())()()()", "()(((())))", "()((()()))", "()((())())", "()((()))()", "()(()(()))", "()(()()())", "()(()())()", "()(())(())", "()(())()()", "()()((()))", "()()(()())", "()()(())()", "()()()(())", "()()()()()" } };
        }

        [Theory]
        [MemberData(nameof(GenerateParenthesisTestData))]
        public void GenerateParenthesesSolution_Test(int n, List<string> expected)
        {
            var solution = new GenerateParenthesesSolution();
            var result = solution.GenerateParenthesis(n);
            Assert.Equal(expected, result);
        }
    }
}
