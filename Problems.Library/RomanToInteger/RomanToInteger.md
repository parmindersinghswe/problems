# Roman to Integer

## Description

This project provides a solution to convert a Roman numeral to an integer. Roman numerals are represented by seven different symbols:

| Symbol | Value |
|--------|-------|
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

Roman numerals are usually written from largest to smallest from left to right. However, some numerals use subtraction for certain values:
- `I` can be placed before `V` (5) and `X` (10) to make 4 and 9.
- `X` can be placed before `L` (50) and `C` (100) to make 40 and 90.
- `C` can be placed before `D` (500) and `M` (1000) to make 400 and 900.

Given a Roman numeral, the goal is to convert it to an integer.

## Examples

### Example 1
**Input:** `s = "III"`  
**Output:** `3`  
**Explanation:** `III = 3`

### Example 2
**Input:** `s = "LVIII"`  
**Output:** `58`  
**Explanation:** `L = 50, V = 5, III = 3`

### Example 3
**Input:** `s = "MCMXCIV"`  
**Output:** `1994`  
**Explanation:** `M = 1000, CM = 900, XC = 90, IV = 4`

## Constraints

- The length of the string `s` is between 1 and 15.
- The string `s` contains only the characters `I`, `V`, `X`, `L`, `C`, `D`, `M`.
- It is guaranteed that `s` is a valid Roman numeral within the range from 1 to 3999.
