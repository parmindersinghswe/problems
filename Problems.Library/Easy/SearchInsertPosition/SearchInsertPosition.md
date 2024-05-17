# Search Insert Position

## Problem Description

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

## Examples

### Example 1

**Input:**
```makefile
nums = [1, 3, 5, 6]
target = 5
```
**Output:**
```
2
```
### Explanation: 
The target value 5 is found at index 2.


### Example 2

**Input:**
```makefile
nums = [1, 3, 5, 6]
target = 2

```
**Output:**
```
1
```
### Explanation: 
The target value 2 is not found, but it would be inserted at index 1 to maintain the order.


### Example 3

**Input:**
```makefile
nums = [1, 3, 5, 6]
target = 7
```
**Output:**
```
4
```
### Explanation: 
The target value 7 is not found, but it would be inserted at index 4 to maintain the order.

## Constraints
- 1 <= nums.length <= 10^4
- -10^4 <= nums[i] <= 10^4
- nums contains distinct values sorted in ascending order.
- -10^4 <= target <= 10^4