using Problems.Library.Easy.NumberOfOneBits;

namespace Problems.Test.Easy
{
    public class NumberOfOneBitsTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void HammingWeight_Tests(uint n, uint expected)
        {
            var solution = new NumberOfOneBitsSolution();
            Assert.Equal(expected, solution.HammingWeight(n));
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { 11u, 3 },
            new object[] { 128u, 1 },
            new object[] { 2147483645u, 30 },
            new object[] { 0u, 0 },
            new object[] { 1u, 1 },
            new object[] { uint.MaxValue, 32 },  // All bits set for a 32-bit unsigned integer
            new object[] { 4294967294u, 31 },  // All bits set except the least significant bit
            new object[] { 15u, 4 },  // Binary 1111
            new object[] { 16u, 1 },  // Binary 10000
            new object[] { 255u, 8 },  // Binary 11111111
            new object[] { 1023u, 10 },  // Binary 1111111111
            new object[] { 2047u, 11 },  // Binary 11111111111
            new object[] { 4095u, 12 },  // Binary 111111111111
            new object[] { 8191u, 13 },  // Binary 1111111111111
            new object[] { 16383u, 14 },  // Binary 11111111111111
            new object[] { 32767u, 15 },  // Binary 111111111111111
            new object[] { 65535u, 16 },  // Binary 1111111111111111
            new object[] { 131071u, 17 },  // Binary 11111111111111111
            new object[] { 262143u, 18 },  // Binary 111111111111111111
            new object[] { 524287u, 19 },  // Binary 1111111111111111111
            new object[] { 1048575u, 20 },  // Binary 11111111111111111111
        };
        }
    }
}
