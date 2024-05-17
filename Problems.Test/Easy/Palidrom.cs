using Problems.Library.Easy.Palidrom.NumberPalidrom;

namespace Problems.Test.Easy
{
    public class Palidrom
    {
        [Fact]
        public void PalidromTest()
        {
            NumberPalidromSolution palidrom = new NumberPalidromSolution();
            bool result = palidrom.IsPalindrome(121);
            bool expected = true;
            Assert.Equal(result, expected);
            result = palidrom.IsPalindrome(-121);
            expected = false;
            Assert.Equal(result, expected);
            result = palidrom.IsPalindrome(10);
            expected = false;
            Assert.Equal(result, expected);
        }
    }
}
