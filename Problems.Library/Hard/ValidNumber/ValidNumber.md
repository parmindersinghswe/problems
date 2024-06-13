# Valid Number

## Problem Statement
Given a string `s`, return whether `s` is a valid number.

### Valid Numbers:
- "2"
- "0089"
- "-0.1"
- "+3.14"
- "4."
- "-.9"
- "2e10"
- "-90E3"
- "3e+7"
- "+6e-1"
- "53.5e93"
- "-123.456e789"

### Invalid Numbers:
- "abc"
- "1a"
- "1e"
- "e3"
- "99e2.5"
- "--6"
- "-+3"
- "95a54e53"

### Formal Definitions:
- **Integer number**: An optional sign ('-' or '+') followed by digits.
- **Decimal number**: An optional sign ('-' or '+') followed by one of the following:
  - Digits followed by a dot ('.').
  - Digits followed by a dot ('.') followed by digits.
  - A dot ('.') followed by digits.
- **Exponent**: An exponent notation ('e' or 'E') followed by an integer number.

## Examples

### Example 1:
```
Input: s = "0"
Output: true
```

### Example 2:
```
Input: s = "e"
Output: false
```

### Example 3:
```
Input: s = "."
Output: false
```

## Constraints:
- `1 <= s.length <= 20`
- `s` consists of only English letters (both uppercase and lowercase), digits (0-9), plus ('+'), minus ('-'), or dot ('.').

## Notes:
- The function should return `true` if the string `s` is a valid number according to the formal definitions provided.
- Handle edge cases such as strings with only signs, dots, or exponent symbols.
