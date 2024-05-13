## Solution Overview
To determine if a number is a palindrome, we can utilize a mathematical approach where we reverse half of the number and compare it with the other half. This method avoids the need to convert the number into a string or other data structures, thus optimizing memory usage.

## Key Points
- Negative numbers and any number ending in 0 (except 0 itself) are not palindromes.
- We reverse the second half of the number and compare it to the first half. If they are equal (or equal when the middle digit is ignored in the case of odd-length numbers), the number is a palindrome.

## Optimized Solution
Here is an optimized C# implementation of the solution:

```csharp
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int reversedHalf = 0;
        while (x > reversedHalf) {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        return x == reversedHalf || x == reversedHalf / 10;
    }
}