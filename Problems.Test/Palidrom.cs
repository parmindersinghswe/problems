namespace Problems.Test
{
    public class Palidrom
    {
        [Fact]
        public void PalidromTest()
        {
            Library.Palidrom.NumberPalidrom.NumberPalidromSolution palidrom = new Library.Palidrom.NumberPalidrom.NumberPalidromSolution();
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
