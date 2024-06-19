# Product of Array Except Self

## Problem Description

Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

## Examples

### Example 1

**Input:** 
```
nums = [1, 2, 3, 4]
```

**Output:** 
```
[24, 12, 8, 6]
```

### Example 2

**Input:** 
```
nums = [-1, 1, 0, -3, 3]
```

**Output:** 
```
[0, 0, 9, 0, 0]
```

## Constraints

- \(2 \leq \text{nums.length} \leq 100,000\)
- \(-30 \leq \text{nums[i]} \leq 30\)
- The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.