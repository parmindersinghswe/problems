using Problems.Library.Medium.StringToInteger;

namespace Problems.Test.Medium
{
    public class StringToIntegerTests
    {
        public static IEnumerable<object[]> MyAtoiTestData()
        {
            yield return new object[] { "42", 42 };
            yield return new object[] { "   -42", -42 };
            yield return new object[] { "4193 with words", 4193 };
            yield return new object[] { "words and 987", 0 };
            yield return new object[] { "-91283472332", Int32.MinValue }; 
            yield return new object[] { "2147483648", Int32.MaxValue };
            yield return new object[] { "+1", 1 };
            yield return new object[] { "   +0 123", 0 };
            yield return new object[] { "00000-42a1234", 0 };
            yield return new object[] { "-5-", -5 };
            yield return new object[] { "   0000000000012345678", 12345678 };
            yield return new object[] { "   +123456789012345", 2147483647 }; 
            yield return new object[] { "   -123456789012345", -2147483648 }; 
            yield return new object[] { "   +0", 0 }; 
            yield return new object[] { "   -0", 0 }; 
            yield return new object[] { "2147483647", 2147483647 }; 
            yield return new object[] { "-2147483648", -2147483648 }; 
            yield return new object[] { "2147483646", 2147483646 }; 
            yield return new object[] { "-2147483647", -2147483647 }; 
            yield return new object[] { "   2147483648", 2147483647 }; 
            yield return new object[] { "   -2147483649", -2147483648 }; 
            yield return new object[] { "   + 413", 0 }; 
        }

        [Theory]
        [MemberData(nameof(MyAtoiTestData))]
        public void Test_MyAtoi(string s, int expected)
        {
            StringToIntegerSolution solution = new StringToIntegerSolution();
            int result = solution.MyAtoi(s);
            Assert.Equal(expected, result);
        }
    }
}
